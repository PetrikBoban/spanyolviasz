
//bootstrap import 
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap'
// router import
import router from './router.js'

// axios import
import axios from 'axios'


import './assets/openpage.css'

import { createApp } from 'vue'
import App from './App.vue'

createApp(App)
.use(router)
.use(axios)
.mount('#app')

