import React from "react";

export interface TripCardLineProps {
  firstElementSvg: JSX.Element;
  firstElementText: string;
  secondElementSvg?: JSX.Element;
  secondElementText?: string;
}

export const TripCardLine = ({
  firstElementSvg,
  firstElementText,
  secondElementSvg,
  secondElementText,
}: TripCardLineProps) => {
  return (
    <div className="flex flex-row mt-2 items-center flex-start">
      <p className="flex items-center my-2 mr-8 text-left text-gray-500 text-sm truncate">
        <span className="mr-1">{firstElementSvg}</span>
        {firstElementText}
      </p>
      {secondElementText && secondElementSvg && (
        <p className="flex items-center my-2 text-left text-gray-500 text-sm truncate">
          <span className="mr-1">{secondElementSvg}</span>
          {secondElementText}
        </p>
      )}
    </div>
  );
};
