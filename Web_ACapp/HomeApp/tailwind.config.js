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
      black: "#121212",
      white: "#FFFDFD",

      blue: {
        l: "#B0D0EB",
        n: "#015B70",
      },
      red: { l: "#945C50", n: "#701A07" },
      yellow: { n: "#FBD270", l: "", d: "" },
    },
    extend: {},
  },
  plugins: [],
};
