import { CarMetaDto } from "../../models/response-models/car-meta-dto";
import { TripDto } from "../../models/response-models/trip-dto";

export interface Context {
  error?: string;
  login: {
    id?: number;
    username?: string;
    apiKey?: string;
    car?: CarMetaDto;
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
    SEARCH_TRIPS: {
      states: {
        LOAD_SEARCH_TRIPS: {};
        LIST_SEARCH_TRIPS: {};
      };
    };
    CAR_MENU: {};
  };
};
