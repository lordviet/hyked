import React from "react";
import "./App.css";

import { HomePage } from "./components/HomePage/HomePage";
import { StartTrip } from "./components/StartTrip/StartTrip";

import { useMachine } from "@xstate/react";
import { tripMachine } from "./machines/trip-machine/trip-machine";

function App() {
  const [current, send] = useMachine(tripMachine);
  const context = current.context;

  return (
    <div className="App">
      {current.matches("HOME") && <HomePage send={send} />}
      {current.matches("START_TRIP") && <StartTrip send={send} />}
    </div>
  );
}

export default App;
