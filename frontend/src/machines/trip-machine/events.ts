export type TOWARDS_START_TRIP = "TOWARDS_START_TRIP";
export type TOWARDS_LIST_TRIPS = "TOWARDS_LIST_TRIPS";
export type TOWARDS_REGISTER = "TOWARDS_REGISTER";
export type TOWARDS_LOGIN = "TOWARDS_LOGIN";
export type TOWARDS_HOME = "TOWARDS_HOME";

export type Events =
  | { type: TOWARDS_START_TRIP }
  | { type: TOWARDS_LIST_TRIPS }
  | { type: TOWARDS_REGISTER }
  | { type: TOWARDS_LOGIN }
  | { type: TOWARDS_HOME };

export type EventTypes = Events["type"];
