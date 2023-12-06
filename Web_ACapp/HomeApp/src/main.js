import "./assets/style.css";

import { createApp } from "vue";
import App from "./App.vue";
import router from "./router";
import "maz-ui/styles"; // or import 'maz-ui/css/main.css'

const app = createApp(App);

app.use(router);

app.mount("#app");
