import React from "react";
import { locationSvg } from "../../../shared/svgElements";

interface JoinTripModalTextInputProps {
  autoFocus?: boolean;
  heading: string;
  setValue: (value: string) => void;
}

export const JoinTripModalTextInput = ({
  autoFocus,
  heading,
  setValue,
}: JoinTripModalTextInputProps) => {
  return (
    <div className="my-8">
      <label className="block text-left font-medium text-gray-700">
        {heading}
      </label>
      <div className="mt-1 relative rounded-md shadow-sm">
        <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
          {locationSvg}
        </div>
        <input
          type="text"
          autoFocus={autoFocus ? true : false}
          name={heading.toLowerCase()}
          onChange={({ target }) => {
            setValue(target.value);
          }}
          id={heading}
          className="focus:ring-indigo-500 focus:border-indigo-500 block w-full py-4 pl-12 sm:text-sm border border-gray-300 rounded-md"
          placeholder="City..."
        />
      </div>
    </div>
  );
};
