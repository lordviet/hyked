module.exports = {
  plugins: [require("@tailwindcss/forms")],
  purge: {
    mode: "all",
    content: ["./src/**/*.{js,jsx,ts,tsx}", "./public/index.html"],
  },
  prefix: "",
  important: false,
  separator: ":",
  theme: {
    extend: {
      zIndex: {
        "-10": "-10",
      },
      screens: {
        xxs: "319px", // zebra
        xs: "375px", // iphone, OnePlus
        sm: "640px",
        md: "768px",
        lg: "1024px",
        // xl: "1280px",
      },
      colors: {
        purple: {
          100: "#faf5ff",
          200: "#e9d8fd",
          300: "#d6bcfa",
          400: "#b794f4",
          500: "#9f7aea",
          600: "#805ad5",
          700: "#6b46c1",
          800: "#553c9a",
          900: "#44337a",
          "4dscale": "#3d1a76",
        },
        gray: {
          400: "#ddd",
        },
      },
    },
  },
  variants: {
    extend: {
      divideStyle: ["hover"],
      backgroundColor: ["group-focus", "active"],
      borderColor: ["group-focus"],
      boxShadow: ["group-focus"],
      opacity: ["group-focus"],
      textColor: ["group-focus", "active"],
      textDecoration: ["group-focus"],
    },
  },
  future: {
    removeDeprecatedGapUtilities: true,
    purgeLayersByDefault: true,
  },
};
