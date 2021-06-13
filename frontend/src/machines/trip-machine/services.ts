import { Events } from "./events";
import { Context } from "./states-context";
import { Register } from "../../api/register";
import axios from "axios";
import { BaseUri } from "../../shared/constants";

export const fetchTrips = () => console.log("tripsFetched");

export const eventErrorType = (event: string, expected: string) => {
  throw new Error(
    `Wrong event type received. Event received is ${event} but was supposed to be ${expected}`
  );
};

export const validateRegister = async (_: Context, event: Events) => {
  if (event.type !== "TOWARDS_VALIDATE_REGISTER") {
    return eventErrorType(event.type, "TOWARDS_VALIDATE_REGISTER");
  }

  console.log("HEER");
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
    // const result = await Register(username, password, phoneNumber);
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

    const result = await axios({
      method: "get",
      headers: {
        "Access-Control-Allow-Origin": "*",
      },
      url: `${BaseUri}/api/trips`,
    });

    console.log("RESULT, ", result);
    return result;
  } catch (error) {
    throw error;
  }
};
