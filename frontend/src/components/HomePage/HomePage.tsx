import React, { useState } from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";
import { TripDto } from "../../models/response-models/trip-dto";
import { JoinTripModal } from "../Modals/JoinTripModal/JoinTripModal";
import { TripsList } from "../TripsList/TripsList";

interface HomePageProps {
  trips?: TripDto[];
  send: (event: EventTypes, payload?: EventData | undefined) => {};
}

export const HomePage = ({ trips, send }: HomePageProps) => {
  const [isJoinTripModalOpen, setIsJoinTripModalOpen] = useState(false);
  console.log("trips in component ", trips);
  return (
    <>
      {/* <Header /> */}
      <main>
        <div>
          <div className="relative">
            <div className="absolute inset-x-0 bottom-0 h-1/2 bg-gray-100" />
            <div className="max-w-7xl mx-auto sm:px-6 lg:px-8">
              <div className="relative shadow-xl sm:rounded-2xl sm:overflow-hidden">
                <div className="absolute inset-0">
                  <img
                    className="h-full w-full object-cover"
                    src="https://i.ibb.co/M1vKv3N/football-stadium-3404535-1920.jpg"
                    alt="People working on laptops"
                  />
                  <div className="absolute inset-0 bg-indigo-700 mix-blend-multiply" />
                </div>
                <div className="relative px-4 py-16 sm:px-6 sm:py-24 lg:py-32 lg:px-8">
                  <h1 className="text-center text-4xl font-extrabold tracking-tight sm:text-5xl lg:text-6xl">
                    <span className="block text-white">
                      Take control of your
                    </span>
                    <span className="block text-indigo-200">trips</span>
                  </h1>
                  <p className="mt-6 max-w-lg mx-auto text-center text-xl text-indigo-200 sm:max-w-3xl">
                    Are you a driver looking for some company or a passenger
                    looking for transport? Hyked is a travel-sharing platform
                    that connects both sides with ease.
                  </p>
                  <div className="mt-10 max-w-sm mx-auto sm:max-w-none sm:flex sm:justify-center">
                    <div className="space-y-4 sm:space-y-0 sm:mx-auto sm:inline-grid sm:grid-cols-2 sm:gap-5">
                      <button
                        onClick={() => send("TOWARDS_START_TRIP")}
                        className="flex w-full items-center justify-center px-4 py-3 border border-transparent text-base font-medium rounded-md shadow-sm text-indigo-700 bg-white hover:bg-indigo-50 sm:px-8"
                      >
                        Start a trip
                      </button>
                      <button
                        onClick={() => {
                          //TODO in the modal send("TOWARDS_JOIN_TRIP");
                          setIsJoinTripModalOpen(!isJoinTripModalOpen);
                        }}
                        className="flex w-full items-center justify-center px-4 py-3 border border-transparent text-base font-medium rounded-md shadow-sm text-white bg-indigo-500 bg-opacity-60 hover:bg-opacity-70 sm:px-8"
                      >
                        Join a trip
                      </button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        {isJoinTripModalOpen && (
          <JoinTripModal
            isOpen={isJoinTripModalOpen}
            closeModal={() => setIsJoinTripModalOpen(false)}
          />
        )}
        <div className="bg-gray-100">
          <div className="max-w-7xl mx-auto py-16 px-4 sm:px-6 lg:px-8">
            <h2 className="text-4xl text-left pb-16">Available trips</h2>
            {trips && <TripsList trips={trips} />}
          </div>
        </div>
      </main>
    </>
  );
};
