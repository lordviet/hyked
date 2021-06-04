export type TOWARDS_START_TRIP = "TOWARDS_START_TRIP";
export type TOWARDS_JOIN_TRIP = "TOWARDS_JOIN_TRIP";
export type TOWARDS_HOME = "TOWARDS_HOME";

export type Events =
  | { type: TOWARDS_START_TRIP }
  | { type: TOWARDS_JOIN_TRIP }
  | { type: TOWARDS_HOME };

export type EventTypes = Events["type"];
