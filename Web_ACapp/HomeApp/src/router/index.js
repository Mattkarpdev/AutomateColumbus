import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";

import GuidesView from "../views/GuidesView.vue";
import RingAlarmGuide from "../components/guides/RingAlarmGuide.vue";
import DoorbellGuide from "../components/guides/DoorbellGuide.vue";

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
    {
      path: "/guides/ringalarmguide",
      name: "ringalarmguide",
      component: RingAlarmGuide,
    },
    {
      path: "/guides/doorbellguide",
      name: "doorbellguide",
      component: DoorbellGuide,
    },
  ],

  scrollBehavior(to, from, savedPosition) {
    // always scroll to top
    return { top: 0 };
  },
});

export default router;
