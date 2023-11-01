/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./index.html",
    "./src/**/*.{vue,js,ts,jsx,tsx}",
    "./src/views/*.{vue,js,ts,jsx,tsx}",
    "src/components/*.{vue,js,ts,jsx,tsx}",
    "./node_modules/vue-rss-feed/src/**/*.{vue,js,ts,jsx,tsx}",
    "./node_modules/vue-rss-feed/src/*.{vue,js,ts,jsx,tsx}",
  ],
  theme: {
    fontFamily: {
      main: "league-spartan",
      title: "neue-black",
    },
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
