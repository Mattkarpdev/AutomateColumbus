/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./index.html",
    "./src/**/*.{vue,js,ts,jsx,tsx}",
    "./src/views/*.{vue,js,ts,jsx,tsx}",
    "src/components/*.{vue,js,ts,jsx,tsx}",
  ],
  theme: {
    colors: {
      white: "#ffffff",
      blue: "#015B70",
      red: "#701A07",
      yellow: "#FBD270",
    },
    extend: {},
  },
  plugins: [],
};
