import React from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";

interface JoinTripProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
}

export const JoinTrip = ({ send }: JoinTripProps) => {
  return <h1>Join this trip</h1>;
};
