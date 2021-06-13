import React from "react";
import "./App.css";

import { Toaster } from "react-hot-toast";

import { useMachine } from "@xstate/react";
import { tripMachine } from "./machines/trip-machine/trip-machine";

import { Login } from "./components/Login/Login";
import { Header } from "./components/Header/Header";
import { Register } from "./components/Login/Register";
import { HomePage } from "./components/HomePage/HomePage";
import { StartTrip } from "./components/StartTrip/StartTrip";

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
      <Toaster
        position="bottom-center"
        toastOptions={{
          style: {
            margin: "40px",
            maxWidth: "500px",
            background: "#363636",
            color: "#fff",
            zIndex: 100,
          },
        }}
      />
      {!isLogin && !isRegister && <Header send={send} />}
      {isHome && <HomePage send={send} />}
      {isLogin && <Login send={send} />}
      {isRegister && <Register send={send} />}
      {isStartTrip && <StartTrip send={send} />}
    </div>
  );
}

export default App;
