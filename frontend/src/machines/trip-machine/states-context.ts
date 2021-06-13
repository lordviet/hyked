export interface Context {
  apiKey?: string | null;
}

export type StateSchema = {
  states: {
    VALIDATE_API_KEY: {};
    LOGIN: {};
    REGISTER: {
      states: {
        IDLE: {};
        VALIDATE_REGISTER: {};
      };
    };
    HOME: {};
    START_TRIP: {};
    LIST_TRIPS: {};
  };
};
