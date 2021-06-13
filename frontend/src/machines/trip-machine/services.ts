import { Events } from "./events";
import { Context } from "./states-context";
import axios from "axios";
import { BaseUri, LocalStorageApiKey } from "../../shared/constants";
import { UserDto } from "../../models/response-models/user-dto";
import { UserRequest } from "../../models/request-models/user-request";

export const fetchTrips = () => console.log("tripsFetched");

export const eventErrorType = (event: string, expected: string) => {
  throw new Error(
    `Wrong event type received. Event received is ${event} but was supposed to be ${expected}`
  );
};

export const validateLogin = async (_: Context, event: Events) => {
  if (event.type !== "TOWARDS_VALIDATE_LOGIN") {
    return eventErrorType(event.type, "TOWARDS_VALIDATE_LOGIN");
  }

  const username = event.username;
  const password = event.password;

  try {
    const result = await axios.get<UserDto>(
      `${BaseUri}/api/users/login?username=${username}&password=${password}`
    );

    const userMeta = result.data;
    localStorage.setItem(LocalStorageApiKey, userMeta.apiKey);
    // localStorage.setItem("userMeta", JSON.stringify(result.data));

    console.log("RESULT, ", userMeta);
    return userMeta;
  } catch (error) {
    throw error;
  }
};

export const validateRegister = async (_: Context, event: Events) => {
  if (event.type !== "TOWARDS_VALIDATE_REGISTER") {
    return eventErrorType(event.type, "TOWARDS_VALIDATE_REGISTER");
  }

  const username = event.username;
  const password = event.password;
  const confirmPassword = event.confirmPassword;
  const phoneNumber = event.phoneNumber;

  if (password.length < 5) {
    throw new Error("Sorry, your password must be at least 5 characters long.");
  }

  if (password !== confirmPassword) {
    throw new Error("Sorry, the passwords do not match.");
  }

  try {
    // const result = await axios({
    //   method: "post",
    //   headers: {
    //     "Access-Control-Allow-Origin": "*",
    //   },
    //   url: `${BaseUri}/api/users/register`,
    //   data: {
    //     username,
    //     password,
    //     phoneNumber,
    //   },
    // });
    const userRequest: UserRequest = { username, password, phoneNumber };

    const result = await axios.post<UserDto>(
      `${BaseUri}/api/users/register`,
      userRequest
    );

    const userMeta = result.data;
    localStorage.setItem(LocalStorageApiKey, userMeta.apiKey);
    // localStorage.setItem("userMeta", JSON.stringify(result.data));

    console.log("RESULT, ", userMeta);
    return userMeta;
  } catch (error) {
    throw error;
  }
};

export const validateApiKey = async (context: Context, _: Events) => {
  const apiKey =
    context.login.apiKey || localStorage.getItem(LocalStorageApiKey);
  console.log(context);
  if (!apiKey) {
    throw new Error("No API key found");
  }
};
