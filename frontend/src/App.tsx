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
import { SearchTrips } from "./components/SearchTrips/SearchTrips";

function App() {
  const [current, send] = useMachine(tripMachine);
  const context = current.context;

  // const isValidateToken = current.matches("VALIDATE_TOKEN");
  const isLogin = current.matches("LOGIN");
  const isRegister = current.matches("REGISTER");
  const isHome = current.matches("HOME");
  const isStartTrip = current.matches("START_TRIP");
  const isSearchTrips = current.matches("SEARCH_TRIPS");

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
      {isHome && (
        <HomePage
          username={context.login.username}
          trips={context.trips}
          send={send}
        />
      )}
      {isLogin && <Login send={send} />}
      {isRegister && <Register send={send} />}
      {isStartTrip && <StartTrip car={context.login.car} send={send} />}
      {isSearchTrips && (
        <SearchTrips
          username={context.login.username}
          send={send}
          trips={context.trips}
        />
      )}
    </div>
  );
}

export default App;
