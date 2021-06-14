import React from "react";

interface LoginFormButtonProps {
  disabled?: boolean;
  title: string;
  onClick: () => void;
}

export const LoginFormButton = ({
  disabled,
  title,
  onClick,
}: LoginFormButtonProps) => {
  return (
    <div className="mt-6">
      <button
        disabled={disabled}
        type="button"
        className={`${
          disabled
            ? "bg-gray-900 pointer-events-none cursor-not-allowed opacity-70"
            : "bg-indigo-600"
        } relative w-full flex items-center justify-center py-3 px-4 border border-transparent rounded-md shadow-sm text-base font-medium  text-white  hover:bg-black focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-offset-black focus:ring-purple-600`}
        onClick={onClick}
      >
        <span>{title}</span>
      </button>
    </div>
  );
};
