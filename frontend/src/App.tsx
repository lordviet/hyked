import React from "react";
import "./App.css";

import { HomePage } from "./components/HomePage/HomePage";

import { useMachine } from "@xstate/react";
import { tripMachine } from "./machines/trip-machine/trip-machine";

function App() {
  const [current, send] = useMachine(tripMachine);
  const context = current.context;

  return (
    <div className="App">
      {current.matches("HOME") && <HomePage send={send} />}
    </div>
  );
}

export default App;
