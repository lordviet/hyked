import React, { useEffect, useState } from "react";
import { TripCardLine } from "./TripCardLine";
import axios from "axios";

// Icons
import {
  crossSvg,
  locationSvg,
  phoneSvg,
  tickSvg,
} from "../../shared/svgElements";
import { calendarSvg } from "../../shared/svgElements";
import { clockSvg } from "../../shared/svgElements";
import { gasSvg } from "../../shared/svgElements";
import { seatsSvg } from "../../shared/svgElements";
import { carSvg } from "../../shared/svgElements";
import { BaseUri } from "../../shared/constants";
import { TripDto } from "../../models/response-models/trip-dto";
import { DriverDto } from "../../models/response-models/driver-dto";
import { copyContent } from "../../utils/copy";
import { TripPassengerRequest } from "../../models/request-models/trip-passenger-request";
import toast from "react-hot-toast";

interface TripCardProps {
  username?: string;
  tripMeta: TripDto;
  refreshTrips?: () => void;
}

export const TripCard = ({
  username,
  tripMeta,
  refreshTrips,
}: TripCardProps) => {
  const {
    id,
    fromLocation,
    toLocation,
    departureTimeUtc,
    availableSeats,
    takenSeats,
    isActive,
    price,
    passengers,
  } = tripMeta;

  const relevantDate = new Date(departureTimeUtc);
  const departureHour = `${relevantDate.getUTCHours()}:${relevantDate.getUTCMinutes()}`;
  const departureDate = relevantDate.toLocaleDateString();
  const [driver, setDriver] = useState<null | DriverDto>(null);

  useEffect(() => {
    const fetchDriver = async () => {
      const result = await axios.get<DriverDto>(
        `${BaseUri}/api/trip/${id}/driver`
      );
      setDriver(result.data);
    };

    fetchDriver();
  }, [id]);

  const handleJoinTrip = async (username: string) => {
    const passengerRequest: TripPassengerRequest = {
      passengerUsername: username,
    };
    try {
      await axios.post(
        `${BaseUri}/api/trip/${id}/passengers`,
        passengerRequest
      );
      toast.success("Successfully joined trip!");
    } catch (error) {
      toast.error("Could not join trip!");
    }
  };

  const handleLeaveTrip = async (username: string) => {
    try {
      await axios.delete(`${BaseUri}/api/trip/${id}/passengers/${username}`);
      toast.success("Successfully left trip!");
    } catch (error) {
      toast.error("Could not leave trip!");
    }
  };

  return (
    <li className="col-span-1 bg-white rounded-lg shadow divide-y divide-gray-200">
      <div className="w-full flex items-center justify-between p-6 space-x-6">
        <div className="flex-1">
          <div className="flex items-center space-x-6">
            {driver && (
              <h3 className="text-gray-900 font-medium truncate">
                Username: {driver.username}
              </h3>
            )}
            {isActive ? (
              <span className="flex-shrink-0 inline-block px-2 py-0.5 text-green-800 text-xs font-medium bg-green-100 rounded-full">
                Active
              </span>
            ) : (
              <span className="flex-shrink-0 inline-block px-2 py-0.5 text-gray-600 text-xs font-medium bg-gray-200 rounded-full">
                Inactive
              </span>
            )}
          </div>
          <TripCardLine
            firstElementSvg={locationSvg}
            firstElementText={`From: ${fromLocation}`}
            secondElementSvg={locationSvg}
            secondElementText={`To: ${toLocation}`}
          />
          <TripCardLine
            firstElementSvg={calendarSvg}
            firstElementText={`Date: ${departureDate}`}
            secondElementSvg={clockSvg}
            secondElementText={`Hour: ${departureHour}`}
          />
          <TripCardLine
            firstElementSvg={gasSvg}
            firstElementText={`Price: ${price} lv`}
            secondElementSvg={seatsSvg}
            secondElementText={`Seats: ${takenSeats} out of ${availableSeats}`}
          />
          {driver && (
            <TripCardLine
              firstElementSvg={carSvg}
              firstElementText={`Car: ${driver.car.manufacturer} ${driver.car.model}`}
            />
          )}
        </div>
      </div>
      <div>
        <div className="-mt-px flex divide-x divide-gray-200">
          {isActive && (
            <div className="w-0 flex-1 flex">
              {username &&
              passengers.find((p) => p.passengerUsername === username) ? (
                <button
                  onClick={async () => {
                    if (username) {
                      await handleLeaveTrip(username);
                      refreshTrips && refreshTrips();
                    }
                  }}
                  className="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500"
                >
                  {crossSvg}
                  <span className="ml-3">Leave trip</span>
                </button>
              ) : (
                <button
                  onClick={async () => {
                    if (username) {
                      await handleJoinTrip(username);
                      refreshTrips && refreshTrips();
                    }
                  }}
                  className="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500"
                >
                  {tickSvg}
                  <span className="ml-3">Join trip</span>
                </button>
              )}
            </div>
          )}
          <div className="-ml-px w-0 flex-1 flex">
            <button
              onClick={() => {
                driver &&
                  copyContent(
                    driver.phoneNumber,
                    "Phone number successfully copied to clipboard.",
                    "Could not copy phone number to clipboard."
                  );
              }}
              className="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500"
            >
              {phoneSvg}
              <span className="ml-3">Get number</span>
            </button>
          </div>
        </div>
      </div>
    </li>
  );
};
