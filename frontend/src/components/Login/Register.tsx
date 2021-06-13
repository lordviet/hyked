import React, { useEffect, useState } from "react";
import { EventData } from "xstate";
import { EventTypes } from "../../machines/trip-machine/events";
import { LoginInput } from "./LoginInput";

interface RegisterProps {
  send: (event: EventTypes, payload?: EventData | undefined) => {};
}

export const Register = ({ send }: RegisterProps) => {
  const [username, setUsername] = useState<string>("");
  const [phoneNumber, setPhoneNumber] = useState<string>("");
  const [password, setPassword] = useState<string>("");
  const [confirmPassword, setConfirmPassword] = useState<string>("");

  useEffect(() => {
    // if (error) {
    //   send("CLEAR_ERROR");
    // }
  }, [username, phoneNumber, password, confirmPassword, send]);

  const handleOnSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
  };

  const handleOnEnterKey = (e: React.KeyboardEvent<HTMLFormElement>) => {
    if (e.key === "Enter") {
      send("TOWARDS_VALIDATE_REGISTER", {
        username,
        phoneNumber,
        password,
        confirmPassword,
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
          Register your account
        </h2>
        <p className="mt-2 text-center text-sm text-gray-600">
          Already have an account?{"  "}
          <button
            onClick={() => send("TOWARDS_LOGIN")}
            className="font-medium text-indigo-600 hover:text-indigo-500"
          >
            Sign in now
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
              value={phoneNumber}
              setValue={setPhoneNumber}
              title={"Phone number"}
              type={"tel"}
            />
            <LoginInput
              value={password}
              setValue={setPassword}
              title={"Password"}
              type={"password"}
            />
            <LoginInput
              value={confirmPassword}
              setValue={setConfirmPassword}
              title={"Confirm password"}
              type={"password"}
            />

            <div>
              <button
                type="submit"
                className="w-full flex justify-center py-2 px-4 border border-transparent rounded-md shadow-sm text-sm font-medium text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                disabled={
                  !Boolean(username) ||
                  !Boolean(password) ||
                  !Boolean(confirmPassword) ||
                  !Boolean(phoneNumber)
                }
                onClick={() =>
                  send("TOWARDS_VALIDATE_REGISTER", {
                    username,
                    phoneNumber,
                    password,
                    confirmPassword,
                  })
                }
              >
                Register
              </button>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
};
