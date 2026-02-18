import { createRouter, createWebHistory } from "vue-router"
import Home from './pages/Home.vue'
import Offers from './pages/Offers.vue'
import Newad from './pages/Newad.vue'

const routes = [
    {
        path: '/',
        name: 'Home',
        component: Home
    },
    {
        path: '/Offers',
        name: 'Offers',
        component: Offers
    },
    {
        path: '/Newad',
        name: 'Newad',
        component: Newad
    },



]

const router = createRouter({
    history:createWebHistory(),
    routes
})

export default router