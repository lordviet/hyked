import axios from "axios";
import React, { useState, useEffect } from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";
import { CarMetaRequestDto } from "../../models/request-models/car-meta-request";
import { BaseUri } from "../../shared/constants";
import toast from "react-hot-toast";
import { CarMetaDto } from "../../models/response-models/car-meta-dto";

interface AddCarProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
  userId?: number;
}

export const AddCar = ({ send, userId }: AddCarProps) => {
  const [car, setCar] = useState<CarMetaDto | null>(null);

  const [manufacturer, setManufacturer] = useState("");
  const [model, setModel] = useState("");
  const [year, setYear] = useState<number | null>(null);
  const [color, setColor] = useState("");
  const [passengerSeats, setPassengerSeats] = useState<number | null>(null);

  useEffect(() => {
    const fetchCar = async () => {
      const result = await axios.get<CarMetaDto>(
        `${BaseUri}/api/user/${userId}/car`
      );
      setCar(result.data);
    };

    fetchCar();
  }, [userId]);

  const handleOnSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
  };

  const handleCarCreation = async (
    id: number,
    manufacturer: string,
    model: string,
    year: number,
    color: string,
    passengerSeats: number
  ) => {
    const carRequest: CarMetaRequestDto = {
      manufacturer,
      model,
      year,
      color,
      passengerSeats,
    };
    try {
      await axios.post(`${BaseUri}/api/user/${id}/car`, carRequest);
      toast.success("Car successfully added to account.");
      send("TOWARDS_HOME");
    } catch (error) {
      toast.error(error.message);
    }
  };

  const handleCarEdit = async (
    id: number,
    manufacturer: string,
    model: string,
    year: number,
    color: string,
    passengerSeats: number
  ) => {
    const carRequest: CarMetaRequestDto = {
      manufacturer,
      model,
      year,
      color,
      passengerSeats,
    };
    try {
      await axios.put(`${BaseUri}/api/user/${id}/car`, carRequest);
      toast.success("Car successfully eddited.");
      send("TOWARDS_HOME");
    } catch (error) {
      toast.error(error.message);
    }
  };

//   const handleCarDeletion = async (id: number) => {
//     try {
//       await axios.delete(`${BaseUri}/api/user/${id}/car`);
//       toast.success("Car successfully deleted added to account.");
//       send("TOWARDS_HOME");
//     } catch (error) {
//       toast.error(error.message);
//     }
//   };

  return (
    <>
      <div className="bg-gray-100 h-screen">
        <div className="max-w-7xl mx-auto py-6 sm:px-6 lg:px-8">
          <div className="mt-10 sm:mt-0">
            <div className="md:grid md:grid-cols-3 md:gap-6">
              <div className="md:col-span-1">
                {!car ? (
                  <div className="px-4 sm:px-0">
                    <h3 className="text-xl font-medium leading-6 text-gray-900">
                      Add a car to your account
                    </h3>
                    <p className="mt-1 text-md text-left text-gray-600">
                      Adding a car to your account will allow you to start
                      trips. Information about the car will be displayed
                      publicly so please be careful.
                    </p>
                  </div>
                ) : (
                  <div className="px-4 sm:px-0">
                    <h3 className="text-xl font-medium leading-6 text-gray-900">
                      Edit your car
                    </h3>
                    <p className="mt-1 text-md text-left text-gray-600">
                      {`You can edit your ${car.manufacturer} ${car.model} car by filling out the form. Information about the car will be displayed
                      publicly so please be careful.`}
                    </p>
                  </div>
                )}
              </div>
              <div className="mt-5 md:mt-0 md:col-span-2">
                <form action="#" method="POST" onSubmit={handleOnSubmit}>
                  <div className="shadow overflow-hidden sm:rounded-md">
                    <div className="px-4 py-5 bg-white sm:p-6">
                      <div className="grid grid-cols-6 gap-6">
                        <div className="col-span-6 sm:col-span-3">
                          <label
                            htmlFor="car_manufacturer"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Manufacturer
                          </label>
                          <input
                            type="text"
                            name="car_manufacturer"
                            id="car_manufacturer"
                            onChange={({ target }) => {
                              setManufacturer(target.value);
                            }}
                            autoComplete="given-name"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3">
                          <label
                            htmlFor="car_model"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Model
                          </label>
                          <input
                            type="text"
                            name="car_model"
                            id="car_model"
                            onChange={({ target }) => {
                              setModel(target.value);
                            }}
                            autoComplete="family-name"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-6 lg:col-span-2">
                          <label
                            htmlFor="year"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Year
                          </label>
                          <input
                            type="number"
                            name="year"
                            id="year"
                            onChange={({ target }) => {
                              setYear(+target.value);
                            }}
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>

                        <div className="col-span-6 sm:col-span-3 lg:col-span-2">
                          <label
                            htmlFor="color"
                            className="block text-sm font-medium text-gray-700"
                          >
                            Color
                          </label>
                          <input
                            type="text"
                            name="color"
                            onChange={({ target }) => {
                              setColor(target.value);
                            }}
                            id="color"
                            autoComplete="color"
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
                            onChange={({ target }) => {
                              setPassengerSeats(+target.value);
                            }}
                            autoComplete="seats"
                            className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                          />
                        </div>
                      </div>
                    </div>
                    <div className="flex justify-end bg-gray-50">
                      <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                        <button
                          type="submit"
                          className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                          onClick={() => send("TOWARDS_HOME")}
                        >
                          Cancel
                        </button>
                      </div>
                      {!car && (
                        <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                          <button
                            type="submit"
                            className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-green-600 hover:bg-green-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                            onClick={async () => {
                              userId &&
                                year &&
                                passengerSeats &&
                                (await handleCarCreation(
                                  userId,
                                  manufacturer,
                                  model,
                                  year,
                                  color,
                                  passengerSeats
                                ));
                            }}
                          >
                            Add car
                          </button>
                        </div>
                      )}
                      {car && (
                        <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                          <button
                            type="submit"
                            className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-yellow-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                            onClick={async () => {
                              userId &&
                                year &&
                                passengerSeats &&
                                (await handleCarEdit(
                                  userId,
                                  manufacturer,
                                  model,
                                  year,
                                  color,
                                  passengerSeats
                                ));
                            }}
                          >
                            Edit car
                          </button>
                        </div>
                      )}
                      {/* {car && (
                        <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                          <button
                            type="submit"
                            className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-red-600 hover:bg-red-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-red-500"
                            onClick={async () => {
                              userId && (await handleCarDeletion(userId));
                            }}
                          >
                            Delete car
                          </button>
                        </div>
                      )} */}
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
