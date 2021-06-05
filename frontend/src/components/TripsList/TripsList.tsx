import React from "react";
import { TripCard } from "../TripCard/TripCard";

// TODO The trips should come from the context in the commented state
export const TripsList = () => {
  return (
    <ul className="grid grid-cols-1 gap-6 sm:grid-cols-2 lg:grid-cols-3">
      <TripCard/>
      <TripCard/>
      <TripCard/>
      <TripCard/>
    </ul>
  );
};
