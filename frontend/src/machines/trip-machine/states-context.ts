export interface Context {
  error?: string;
  login: {
    userId?: number;
    username?: string;
    apiKey?: string;
  };
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
    HOME: {};
    START_TRIP: {};
    LIST_TRIPS: {};
  };
};
