import { TripDto } from "../../models/response-models/trip-dto";

export interface Context {
  error?: string;
  login: {
    userId?: number;
    username?: string;
    apiKey?: string;
  };
  trips?: TripDto[];
}

export type StateSchema = {
  states: {
    VALIDATE_API_KEY: {};
    LOGIN: {
      states: {
        IDLE: {};
        VALIDATE_LOGIN: {};
      };
    };
    REGISTER: {
      states: {
        IDLE: {};
        VALIDATE_REGISTER: {};
      };
    };
    HOME: {
      states: {
        LOAD_TRIPS: {};
        LIST_TRIPS: {};
      };
    };
    START_TRIP: {};
    LIST_SEARCH_TRIPS: {};
  };
};
