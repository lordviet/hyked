import React, { useEffect, useState } from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../../machines/trip-machine/events";
import { searchSvg, xSvg } from "../../../shared/svgElements";
import { JoinTripModalTextInput } from "./JoinTripModalTextInput";

interface JoinTripModalProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
  isOpen: boolean;
  closeModal: () => void;
}

export const JoinTripModal = ({
  send,
  isOpen,
  closeModal,
}: JoinTripModalProps) => {
  const [fromLocation, setFromLocation] = useState("");
  const [toLocation, setToLocation] = useState("");

  const handleOnSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
  };

  const handleOnEnterKey = (e: React.KeyboardEvent<HTMLFormElement>) => {
    if (e.key === "Enter") {
      send("TOWARDS_SEARCH_TRIPS", {
        fromLocation,
        toLocation,
      });
    }
  };

  useEffect(() => {
    const close = (e: KeyboardEvent) => {
      if (e.keyCode === 27) {
        closeModal();
      }
    };
    window.addEventListener("keydown", close);
    return () => window.removeEventListener("keydown", close);
  }, [isOpen, closeModal]);

  useEffect(() => {
    isOpen && (document.body.style.overflow = "hidden");
    return () => {
      document.body.style.overflow = "auto";
    };
  }, [isOpen]);

  return (
    <form action="#" onSubmit={handleOnSubmit} onKeyPress={handleOnEnterKey}>
      <div
        className="fixed z-10 inset-0 overflow-y-auto"
        aria-labelledby="modal-title"
        role="dialog"
        aria-modal="true"
      >
        <div className="flex items-end justify-center min-h-screen pt-4 px-4 pb-20 text-center sm:block sm:p-0">
          <div
            className="fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity"
            aria-hidden="true"
          ></div>
          <span
            className="hidden sm:inline-block sm:align-middle sm:h-screen"
            aria-hidden="true"
          >
            &#8203;
          </span>
          <div className="inline-block align-bottom bg-white rounded-lg px-4 pt-5 pb-4 text-left overflow-hidden shadow-xl transform transition-all sm:my-8 sm:align-middle sm:max-w-lg sm:w-full sm:p-6">
            <button
              className="absolute top-0 right-0 m-2 text-gray-200 hover:text-gray-500"
              onClick={closeModal}
            >
              {xSvg}
            </button>
            <div>
              <div className="mt-2 text-center sm:mt-4">
                <h3
                  className="text-xl leading-6 font-medium text-gray-900"
                  id="modal-title"
                >
                  Join a shared travel
                </h3>
                <div className="mt-2">
                  <JoinTripModalTextInput
                    setValue={setFromLocation}
                    autoFocus={true}
                    heading={"Travel from"}
                  />
                  <JoinTripModalTextInput
                    setValue={setToLocation}
                    heading={"Travel to"}
                  />
                </div>
              </div>
            </div>
            <div className="mt-5 sm:mt-6 sm:grid sm:grid-cols-2 sm:gap-3 sm:grid-flow-row-dense">
              <button
                disabled={!Boolean(fromLocation) || !Boolean(toLocation)}
                onClick={() =>
                  send("TOWARDS_SEARCH_TRIPS", { fromLocation, toLocation })
                }
                type="button"
                className={`w-full inline-flex justify-center rounded-md border border-transparent shadow-sm px-4 py-2 ${
                  !Boolean(fromLocation) || !Boolean(toLocation)
                    ? "bg-gray-900 pointer-events-none cursor-not-allowed opacity-70"
                    : "bg-indigo-600"
                } text-base font-medium text-white hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500 sm:col-start-2 sm:text-sm`}
              >
                <span className="mr-2">{searchSvg}</span>
                Search
              </button>
              <button
                type="button"
                className="mt-3 w-full inline-flex justify-center rounded-md border border-gray-300 shadow-sm px-4 py-2 bg-white text-base font-medium text-gray-700 hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500 sm:mt-0 sm:col-start-1 sm:text-sm"
                onClick={closeModal}
              >
                Cancel
              </button>
            </div>
          </div>
        </div>
      </div>
    </form>
  );
};
