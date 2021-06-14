import React from "react";
import { TripDto } from "../../models/response-models/trip-dto";
import { TripCard } from "../TripCard/TripCard";

interface TripListProps {
  username?: string;
  trips: TripDto[];
  refreshTrips?: () => void;
}

export const TripsList = ({ username, trips, refreshTrips }: TripListProps) => {  
  return (
    <ul className="grid grid-cols-1 gap-6 sm:grid-cols-2 lg:grid-cols-3">
      {trips
        .filter((trip) => trip.isActive)
        .map((trip) => (
          <TripCard username={username} key={trip.id} tripMeta={trip} refreshTrips={refreshTrips} />
        ))}
    </ul>
  );
};
