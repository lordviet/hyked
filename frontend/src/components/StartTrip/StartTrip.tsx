import React from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";

interface StartTripProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
}

export const StartTrip = ({ send }: StartTripProps) => {
  return (
    <>
      <div className="bg-gray-100 h-screen">
        <div className="max-w-7xl mx-auto py-6 sm:px-6 lg:px-8">
          <div className="mt-10 sm:mt-0">
            <div className="md:grid md:grid-cols-3 md:gap-6">
              <div className="md:col-span-1">
                <div className="px-4 sm:px-0">
                  <h3 className="text-xl font-medium leading-6 text-gray-900">
                    Start a shared trip
                  </h3>
                  <p className="mt-1 text-md text-left text-gray-600">
                    This information will be displayed publicly so please be
                    careful when filling out details.
                  </p>
                </div>
              </div>
              <div className="mt-5 md:mt-0 md:col-span-2">
                <form action="#" method="POST">
                  <div className="shadow overflow-hidden sm:rounded-md">
                    <div className="px-4 py-5 bg-white sm:p-6">
                      <div className="grid grid-cols-6 gap-6">
                        <div className="col-span-6 sm:col-span-3">
                          <label
                            htmlFor="trip_from"
                            className="block text-sm font-medium text-gray-700"
                          >
                            From
                          </label>
                          <input
                            type="text"
                            name="trip_from"
                            id="trip_from"
                            autoComplete="given-name"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3">
                          <label
                            htmlFor="trip_to"
                            className="block text-sm font-medium text-gray-700"
                          >
                            To
                          </label>
                          <input
                            type="text"
                            name="trip_to"
                            id="trip_to"
                            autoComplete="family-name"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-6 lg:col-span-2">
                          <label
                            htmlFor="date"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Date
                          </label>
                          <input
                            type="date"
                            name="date"
                            id="date"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3 lg:col-span-2">
                          <label
                            htmlFor="state"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Hour
                          </label>
                          <input
                            type="time"
                            name="state"
                            id="state"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3 lg:col-span-2">
                          <label
                            htmlFor="price"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Price
                          </label>
                          <input
                            type="number"
                            min="0"
                            name="price"
                            id="price"
                            autoComplete="price"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3 lg:col-span-2">
                          <label
                            htmlFor="seats"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Seats
                          </label>
                          <input
                            type="number"
                            min="1"
                            name="seats"
                            id="seats"
                            autoComplete="seats"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3">
                          <label
                            htmlFor="car"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Car
                          </label>
                          <select
                            id="car"
                            name="car"
                            autoComplete="car"
                            className="mt-1 block w-full py-2 px-3 border border-gray-300 bg-white rounded-md shadow-sm focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
                          >
                            <option>Audi a3</option>
                            <option>Golf 3</option>
                          </select>
                        </div>
                      </div>
                    </div>
                    <div className="flex justify-end bg-gray-50">
                      <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                        <button
                          type="submit"
                          className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-red-600 hover:bg-red-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-red-500"
                          onClick={() => send("TOWARDS_HOME")}
                        >
                          Cancel
                        </button>
                      </div>
                      <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                        <button
                          type="submit"
                          className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                        >
                          Create trip
                        </button>
                      </div>
                    </div>
                  </div>
                </form>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};
