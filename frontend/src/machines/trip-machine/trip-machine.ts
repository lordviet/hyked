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
        TOWARDS_JOIN_TRIP: {
          target: "JOIN_TRIP",
        },
      },
    },
    START_TRIP: {},
    JOIN_TRIP: {},
  },
});
