import { assign, Machine } from "xstate";
import { Events } from "./events";
import {
  fetchTrips,
  validateApiKey,
  validateLogin,
  validateRegister,
} from "./services";
import { Context, StateSchema } from "./states-context";

export const tripMachine = Machine<Context, StateSchema, Events>({
  id: "trip",
  initial: "VALIDATE_API_KEY",
  context: {
    login: {
      userId: undefined,
      username: undefined,
      apiKey: undefined,
    },
  },
  states: {
    VALIDATE_API_KEY: {
      invoke: {
        id: "validateApiKey",
        src: validateApiKey,
        onDone: {
          target: "HOME",
        },
        onError: {
          target: "LOGIN",
        },
      },
    },
    LOGIN: {
      id: "login",
      initial: "IDLE",
      states: {
        IDLE: {
          on: {
            TOWARDS_VALIDATE_LOGIN: {
              target: "VALIDATE_LOGIN",
            },
          },
        },
        VALIDATE_LOGIN: {
          invoke: {
            id: "validateLogin",
            src: validateLogin,
            onDone: {
              actions: [
                assign((_, event) => ({
                  login: event.data,
                })),
              ],
              target: "#trip.VALIDATE_API_KEY",
            },
            onError: {
              actions: ["receiveError"],
              target: "IDLE",
            },
          },
        },
      },
    },
    REGISTER: {
      id: "register",
      initial: "IDLE",
      states: {
        IDLE: {
          on: {
            TOWARDS_VALIDATE_REGISTER: {
              target: "VALIDATE_REGISTER",
            },
          },
        },
        VALIDATE_REGISTER: {
          invoke: {
            id: "validateRegister",
            src: validateRegister,
            onDone: {
              actions: [
                assign((_, event) => ({
                  login: event.data,
                })),
              ],
              target: "#trip.VALIDATE_API_KEY",
            },
            onError: {
              actions: ["receiveError"],
              target: "IDLE",
            },
          },
        },
      },
    },
    HOME: {
      id: "home",
      initial: "LOAD_TRIPS",
      on: {
        TOWARDS_START_TRIP: {
          target: "START_TRIP",
        },
        // TOWARDS_LIST_TRIPS: {
        //   target: "LIST_TRIPS",
        // },
      },
      states: {
        LOAD_TRIPS: {
          invoke: {
            id: "fetchTrips",
            src: fetchTrips,
            onDone: {
              target: "#home.LIST_TRIPS",
              actions: [
                assign((context, event) => ({
                  trips: event.data,
                })),
              ],
            },
            onError: {}, // TODO: Show error
          },
        },
        LIST_TRIPS: {},
      },
    },
    START_TRIP: {
      // TODO initial state should check whether the user has a car
    },
    LIST_SEARCH_TRIPS: {},
    // TODO refactor this to become list trips, join trip should open a modal that after that sends an API call
  },
  on: {
    TOWARDS_HOME: { target: "HOME" },
    TOWARDS_LOGIN: { target: "LOGIN" },
    TOWARDS_REGISTER: { target: "REGISTER" },
    RELOAD_TRIPS: { target: "#home.LOAD_TRIPS" },
  },
});
