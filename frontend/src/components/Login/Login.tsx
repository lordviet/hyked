import React, { useEffect, useState } from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";
import { LoginFormButton } from "./LoginButton";
import { LoginInput } from "./LoginInput";

interface LoginProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
}

export const Login = ({ send }: LoginProps) => {
  const [username, setUsername] = useState<string>("");
  const [password, setPassword] = useState<string>("");

  useEffect(() => {
    // if (error) {
    //   send("CLEAR_ERROR");
    // }
  }, [username, password, send]);

  const handleOnSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
  };

  const handleOnEnterKey = (e: React.KeyboardEvent<HTMLFormElement>) => {
    if (e.key === "Enter") {
      send("TOWARDS_VALIDATE_LOGIN", {
        username,
        password,
      });
    }
  };

  return (
    <div className="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8">
      <div className="sm:mx-auto sm:w-full sm:max-w-md">
        <img
          className="mx-auto h-12 w-auto"
          src="https://tailwindui.com/img/logos/workflow-mark-indigo-600.svg"
          alt="Workflow"
        />
        <h2 className="mt-6 text-center text-3xl font-extrabold text-gray-900">
          Sign in to your account
        </h2>
        <p className="mt-2 text-center text-sm text-gray-600">
          Don't have an account?{"  "}
          <button
            onClick={() => send("TOWARDS_REGISTER")}
            className="font-medium text-indigo-600 hover:text-indigo-500"
          >
            Register now
          </button>
        </p>
      </div>

      <div className="mt-8 sm:mx-auto sm:w-full sm:max-w-md">
        <div className="bg-white py-8 px-4 shadow sm:rounded-lg sm:px-10">
          <form
            className="space-y-6"
            action="#"
            method="POST"
            onSubmit={handleOnSubmit}
            onKeyPress={handleOnEnterKey}
          >
            <LoginInput
              value={username}
              setValue={setUsername}
              title={"Username"}
              autoFocus={true}
            />
            <LoginInput
              value={password}
              setValue={setPassword}
              title={"Password"}
              type={"password"}
            />
            <LoginFormButton
              disabled={!Boolean(username) || !Boolean(password)}
              title={"Sign in"}
              onClick={() =>
                send("TOWARDS_VALIDATE_LOGIN", { username, password })
              }
            />
          </form>
        </div>
      </div>
    </div>
  );
};
