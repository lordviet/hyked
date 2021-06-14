import { Events } from "./events";
import { Context } from "./states-context";
import axios from "axios";
import { BaseUri, LocalStorageApiKey } from "../../shared/constants";
import { UserDto } from "../../models/response-models/user-dto";
import { UserRequest } from "../../models/request-models/user-request";
import toast from "react-hot-toast";
import { TripDto } from "../../models/response-models/trip-dto";

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

    console.log("RESULT, ", userMeta);
    return userMeta;
  } catch (error) {
    toast.error("Login failed, please try again.");
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
    toast.error("Sorry, your password must be at least 5 characters long.");
    throw new Error("Sorry, your password must be at least 5 characters long.");
  }

  if (password !== confirmPassword) {
    toast.error("Sorry, the passwords do not match.");
    throw new Error("Sorry, the passwords do not match.");
  }

  try {
    const userRequest: UserRequest = { username, password, phoneNumber };

    const result = await axios.post<UserDto>(
      `${BaseUri}/api/users/register`,
      userRequest
    );

    const userMeta = result.data;
    localStorage.setItem(LocalStorageApiKey, userMeta.apiKey);

    return userMeta;
  } catch (error) {
    const defaultError = "Register failed, please try again";
    toast.error(error.response.detail ?? defaultError);
    throw error;
  }
};

export const validateApiKey = async (context: Context, _: Events) => {
  const apiKey =
    context.login.apiKey || localStorage.getItem(LocalStorageApiKey);

  if (!apiKey) {
    throw new Error("No API key found");
  }
};

export const fetchTrips = async () => {
  const result = await axios.get<TripDto>(`${BaseUri}/api/trips`);

  const trips = result.data;

  return trips;
};

export const fetchSearchTrips = async (context: Context, event: Events) => {
  if (event.type !== "TOWARDS_SEARCH_TRIPS") {
    return eventErrorType(event.type, "TOWARDS_SEARCH_TRIPS");
  }

  const fromLocation = event.fromLocation;
  const toLocation = event.toLocation;

  try {
    const result = await axios.get<TripDto>(
      `${BaseUri}/api/trips/specific/?fromLocation=${fromLocation}&toLocation=${toLocation}`
    );

    return result.data;
  } catch (error) {
    toast.error(error.message);
  }
};
