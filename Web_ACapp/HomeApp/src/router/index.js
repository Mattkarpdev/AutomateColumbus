import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import CalculatorView from '../views/CalculatorView.vue'
import GuidesView from '../views/GuidesView.vue'
import RingAlarmGuide from '../components/guides/RingAlarmGuide.vue'


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView
    },
    {
      path: '/calculator',
      name: 'calculator',
      component: CalculatorView
    },
    {
      path: '/guides',
      name: 'guides',
      component: GuidesView
    },
    {
      path: '/guides/ringalarmguide',
      name: 'ringalarmguide',
      component: RingAlarmGuide
    }



  ]
})

export default router
