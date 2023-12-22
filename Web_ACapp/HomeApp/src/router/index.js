import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";

import GuidesView from "../views/GuidesView.vue";

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },

    {
      path: "/guides",
      name: "guides",
      component: GuidesView,
    },
  ],

  scrollBehavior(to, from, savedPosition) {
    // always scroll to top
    return { top: 0 };
  },
});

export default router;
