import React from "react";
import "./App.css";

import { HomePage } from "./components/HomePage/HomePage";
import { StartTrip } from "./components/StartTrip/StartTrip";

import { useMachine } from "@xstate/react";
import { tripMachine } from "./machines/trip-machine/trip-machine";
import { Header } from "./components/Header/Header";
import { Login } from "./components/Login/Login";
import { Register } from "./components/Login/Register";

function App() {
  const [current, send] = useMachine(tripMachine);
  const context = current.context;

  // const isValidateToken = current.matches("VALIDATE_TOKEN");
  const isLogin = current.matches("LOGIN");
  const isRegister = current.matches("REGISTER");
  const isHome = current.matches("HOME");
  const isStartTrip = current.matches("START_TRIP");
  return (
    <div className="App">
      {!isLogin && !isRegister && <Header />}
      {isHome && <HomePage send={send} />}
      {isLogin && <Login send={send} />}
      {isRegister && <Register send={send} />}
      {isStartTrip && <StartTrip send={send} />}
    </div>
  );
}

export default App;
