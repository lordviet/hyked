import React, { useEffect, useState } from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";
import { LocalStorageApiKey } from "../../shared/constants";
import { carAlternativeSvg, homeSvg } from "../../shared/svgElements";

interface HeaderProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
}

export const Header = ({ send }: HeaderProps) => {
  const [isMobileHeaderOpen, setIsMobileHeaderOpen] = useState(false);
  useEffect(() => {
    const close = (e: KeyboardEvent) => {
      if (e.keyCode === 27) {
        setIsMobileHeaderOpen(false);
      }
    };
    window.addEventListener("keydown", close);
    return () => window.removeEventListener("keydown", close);
  }, [isMobileHeaderOpen]);

  useEffect(() => {
    isMobileHeaderOpen && (document.body.style.overflow = "hidden");
    return () => {
      document.body.style.overflow = "auto";
    };
  }, [isMobileHeaderOpen]);

  return (
    <header>
      <div className="relative bg-white">
        <div className="flex justify-between items-center max-w-7xl mx-auto px-4 py-6 sm:px-6 md:justify-start md:space-x-10 lg:px-8">
          <div className="flex justify-start lg:w-0 lg:flex-1">
            <button>
              <span className="sr-only">Workflow</span>
              <img
                className="h-8 w-auto sm:h-10"
                src="https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg" // use hyked logo
                alt=""
              />
            </button>
          </div>
          <div className="-mr-2 -my-2 md:hidden">
            <button
              onClick={() => setIsMobileHeaderOpen(!isMobileHeaderOpen)}
              type="button"
              className="bg-white rounded-md p-2 inline-flex items-center justify-center text-gray-400 hover:text-gray-500 hover:bg-gray-100 focus:outline-none focus:ring-2 focus:ring-inset focus:ring-indigo-500"
              aria-expanded="false"
            >
              <span className="sr-only">Open menu</span>
              <svg
                className="h-6 w-6"
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
                aria-hidden="true"
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth="2"
                  d="M4 6h16M4 12h16M4 18h16"
                />
              </svg>
            </button>
          </div>
          <nav className="hidden md:flex space-x-10">
            <button
              onClick={() => {
                send("TOWARDS_HOME");
              }}
              className="text-base font-medium text-gray-500 hover:text-gray-900"
            >
              Home
            </button>
            <button
              onClick={() => send("TOWARDS_CAR_MENU")}
              className="text-base font-medium text-gray-500 hover:text-gray-900"
            >
              My car
            </button>
          </nav>
          <div className="hidden md:flex items-center justify-end md:flex-1 lg:w-0">
            <button
              onClick={() => {
                localStorage.removeItem(LocalStorageApiKey);
                send("TOWARDS_LOGIN");
              }}
              className="ml-8 whitespace-nowrap inline-flex items-center justify-center px-4 py-2 border border-transparent rounded-md shadow-sm text-base font-medium text-white bg-indigo-600 hover:bg-indigo-700"
            >
              Log out
            </button>
          </div>
        </div>
        {isMobileHeaderOpen && (
          <div className="absolute z-30 top-0 inset-x-0 p-2 transition transform origin-top-right md:hidden">
            <div
              className="-z-10 fixed h-screen inset-0 bg-gray-500 bg-opacity-75 transition-opacity"
              aria-hidden="true"
            ></div>
            <div className="rounded-lg shadow-lg ring-1 ring-black ring-opacity-5 bg-white divide-y-2 divide-gray-50">
              <div className="pt-5 pb-6 px-5">
                <div className="flex items-center justify-between">
                  <div>
                    <img
                      className="h-8 w-auto"
                      src="https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg"
                      alt="Workflow"
                    />
                  </div>
                  <div className="-mr-2">
                    <button
                      onClick={() => setIsMobileHeaderOpen(false)}
                      type="button"
                      className="bg-white rounded-md p-2 inline-flex items-center justify-center text-gray-400 hover:text-gray-500 hover:bg-gray-100 focus:outline-none focus:ring-2 focus:ring-inset focus:ring-indigo-500"
                    >
                      <span className="sr-only">Close menu</span>
                      <svg
                        className="h-6 w-6"
                        xmlns="http://www.w3.org/2000/svg"
                        fill="none"
                        viewBox="0 0 24 24"
                        stroke="currentColor"
                        aria-hidden="true"
                      >
                        <path
                          strokeLinecap="round"
                          strokeLinejoin="round"
                          strokeWidth="2"
                          d="M6 18L18 6M6 6l12 12"
                        />
                      </svg>
                    </button>
                  </div>
                </div>
                <div className="mt-6">
                  <nav className="grid grid-cols-1 gap-7">
                    <button
                      onClick={() => {
                        send("TOWARDS_HOME");
                      }}
                      className="-m-3 p-3 flex items-center rounded-lg hover:bg-gray-50"
                    >
                      <div className="flex-shrink-0 flex items-center justify-center h-10 w-10 rounded-md bg-indigo-600 text-white">
                        {homeSvg}
                      </div>
                      <div className="ml-4 text-base font-medium text-gray-900">
                        Home
                      </div>
                    </button>
                    <button
                      onClick={() => send("TOWARDS_CAR_MENU")}
                      className="-m-3 p-3 flex items-center rounded-lg hover:bg-gray-50"
                    >
                      <div className="flex-shrink-0 flex items-center justify-center h-10 w-10 rounded-md bg-indigo-600 text-white">
                        {carAlternativeSvg}
                      </div>
                      <div className="ml-4 text-base font-medium text-gray-900">
                        My car
                      </div>
                    </button>
                  </nav>
                </div>
              </div>
              <div className="py-6 px-5">
                <div className="mt-6">
                  <button
                    onClick={() => {
                      localStorage.removeItem(LocalStorageApiKey);
                      send("TOWARDS_LOGIN");
                    }}
                    className="w-full flex items-center justify-center px-4 py-2 border border-transparent rounded-md shadow-sm text-base font-medium text-white bg-indigo-600 hover:bg-indigo-700"
                  >
                    Log out
                  </button>
                </div>
              </div>
            </div>
          </div>
        )}
      </div>
    </header>
  );
};
