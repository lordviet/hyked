import React from "react";

interface LoginInputProps {
  title: string;
  type?: string;
  autoFocus?: boolean;
  value: string;
  setValue: (value: string) => void;
}

export const LoginInput = ({
  title,
  type,
  autoFocus,
  value,
  setValue,
}: LoginInputProps) => {
  return (
    <div>
      <label
        htmlFor={title.toLowerCase()}
        className="block text-sm font-medium text-gray-700"
      >
        {title}
      </label>
      <div className="mt-1">
        <input
          id={title.toLowerCase()}
          name={title.toLowerCase()}
          required
          autoFocus={autoFocus ? true : false}
          type={type ? type : "text"}
          onChange={({ target }) => {
            setValue(target.value);
          }}
          value={value}
          className="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md shadow-sm placeholder-gray-400 focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 sm:text-sm"
        />
      </div>
    </div>
  );
};
