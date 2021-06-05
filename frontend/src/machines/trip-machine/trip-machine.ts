import { Machine } from "xstate";
import { Events } from "./events";
import { Context, StateSchema } from "./states-context";

export const tripMachine = Machine<Context, StateSchema, Events>({
  id: "trip",
  initial: "HOME",
  states: {
    HOME: {
      on: {
        TOWARDS_START_TRIP: {
          target: "START_TRIP",
        },
        TOWARDS_LIST_TRIPS: {
          target: "LIST_TRIPS",
        },
      },
    },
    START_TRIP: {
      // TODO initial state should check whether the user has a car
    },
    LIST_TRIPS: {},
    // TODO refactor this to become list trips, join trip should open a modal that after that sends an API call
  },
  on: {
    TOWARDS_HOME: { target: "HOME" },
  },
});
