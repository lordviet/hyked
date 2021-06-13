import React from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";
import { TripDto } from "../../models/response-models/trip-dto";
import { TripsList } from "../TripsList/TripsList";

interface SearchTripsProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
  trips?: TripDto[];
  username?: string;
}

export const SearchTrips = ({ send, trips, username }: SearchTripsProps) => {
  return (
    <div className="bg-gray-100">
      <div className="max-w-7xl mx-auto py-16 px-4 sm:px-6 lg:px-8">
        {trips && trips.length > 0 && trips.find((t) => t.isActive) ? (
          <>
            <h2 className="text-4xl text-left pb-16">{`Found trips`}</h2>
            {
              <TripsList
                username={username}
                trips={trips}
                refreshTrips={() => send("RELOAD_TRIPS")}
              />
            }
          </>
        ) : (
          <h2 className="text-4xl text-left pb-16">
            No trips matching your criteria.
          </h2>
        )}
      </div>
    </div>
  );
};
