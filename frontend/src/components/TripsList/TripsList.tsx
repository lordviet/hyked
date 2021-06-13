import React from "react";
import { TripDto } from "../../models/response-models/trip-dto";
import { TripCard } from "../TripCard/TripCard";

interface TripListProps {
  trips: TripDto[];
}

export const TripsList = ({ trips }: TripListProps) => {
  return (
    <ul className="grid grid-cols-1 gap-6 sm:grid-cols-2 lg:grid-cols-3">
      {trips
        .filter((trip) => trip.isActive)
        .map((trip) => (
          <TripCard key={trip.id} tripMeta={trip} />
        ))}
    </ul>
  );
};
