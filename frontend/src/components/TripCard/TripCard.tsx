import React from "react";
import { TripCardLine } from "./TripCardLine";

// Icons
import { locationSvg, phoneSvg } from "../../shared/svgElements";
import { calendarSvg } from "../../shared/svgElements";
import { clockSvg } from "../../shared/svgElements";
import { gasSvg } from "../../shared/svgElements";
import { seatsSvg } from "../../shared/svgElements";
import { carSvg } from "../../shared/svgElements";
import { infoSvg } from "../../shared/svgElements";

export const TripCard = () => {
  return (
    <li className="col-span-1 bg-white rounded-lg shadow divide-y divide-gray-200">
      <div className="w-full flex items-center justify-between p-6 space-x-6">
        <div className="flex-1">
          <div className="flex items-center space-x-6">
            <h3 className="text-gray-900 font-medium truncate">Jane Cooper</h3>
            <span className="flex-shrink-0 inline-block px-2 py-0.5 text-green-800 text-xs font-medium bg-green-100 rounded-full">
              Active
            </span>
          </div>
          <TripCardLine
            firstElementSvg={locationSvg}
            firstElementText={"From: Stara Zagora"}
            secondElementSvg={locationSvg}
            secondElementText={"To: Haskovo"}
          />
          <TripCardLine
            firstElementSvg={calendarSvg}
            firstElementText={"Date: 08.06.2021"}
            secondElementSvg={clockSvg}
            secondElementText={"Hour: 21:23"}
          />
          <TripCardLine
            firstElementSvg={gasSvg}
            firstElementText={"Price: 10lv"}
            secondElementSvg={seatsSvg}
            secondElementText={"Seats: 2 out of 3"}
          />
          <TripCardLine
            firstElementSvg={carSvg}
            firstElementText={"Car: Audi a3"}
          />
        </div>
      </div>
      <div>
        <div className="-mt-px flex divide-x divide-gray-200">
          <div className="w-0 flex-1 flex">
            <a
              href="mailto:janecooper@example.com"
              className="relative -mr-px w-0 flex-1 inline-flex items-center justify-center py-4 text-sm text-gray-700 font-medium border border-transparent rounded-bl-lg hover:text-gray-500"
            >
              {infoSvg}
              <span className="ml-3">Details</span>
            </a>
          </div>
          <div className="-ml-px w-0 flex-1 flex">
            <a
              href="tel:+1-202-555-0170"
              className="relative w-0 flex-1 inline-flex items-center justify-center py-4 text-sm text-gray-700 font-medium border border-transparent rounded-br-lg hover:text-gray-500"
            >
              {phoneSvg}
              <span className="ml-3">Get number</span>
            </a>
          </div>
        </div>
      </div>
    </li>
  );
};