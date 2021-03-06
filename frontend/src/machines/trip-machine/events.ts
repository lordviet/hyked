export type TOWARDS_START_TRIP = "TOWARDS_START_TRIP";
export type TOWARDS_LIST_TRIPS = "TOWARDS_LIST_TRIPS";
export type TOWARDS_CAR_MENU = "TOWARDS_CAR_MENU";
export type TOWARDS_REGISTER = "TOWARDS_REGISTER";
export type TOWARDS_VALIDATE_REGISTER = "TOWARDS_VALIDATE_REGISTER";
export type TOWARDS_LOGIN = "TOWARDS_LOGIN";
export type TOWARDS_VALIDATE_LOGIN = "TOWARDS_VALIDATE_LOGIN";
export type TOWARDS_SEARCH_TRIPS = "TOWARDS_SEARCH_TRIPS";
export type TOWARDS_HOME = "TOWARDS_HOME";
export type CLEAR_ERROR = "CLEAR_ERROR";
export type RELOAD_TRIPS = "RELOAD_TRIPS";

export type Events =
  | { type: TOWARDS_START_TRIP }
  | { type: TOWARDS_LIST_TRIPS }
  | { type: TOWARDS_CAR_MENU }
  | { type: TOWARDS_REGISTER }
  | {
      type: TOWARDS_VALIDATE_REGISTER;
      username: string;
      phoneNumber: string;
      password: string;
      confirmPassword: string;
    }
  | { type: TOWARDS_VALIDATE_LOGIN; username: string; password: string }
  | { type: TOWARDS_SEARCH_TRIPS; fromLocation: string; toLocation: string }
  | { type: TOWARDS_LOGIN }
  | { type: TOWARDS_HOME }
  | { type: RELOAD_TRIPS };

export type EventTypes = Events["type"];
