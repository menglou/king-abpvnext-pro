import Vue from 'vue'

import Cookies from 'js-cookie'

import 'normalize.css/normalize.css' // a modern alternative to CSS resets

import ElementUI from 'element-ui'
import 'element-ui/lib/theme-chalk/index.css'
import 'element-ui/lib/theme-chalk/display.css'

import * as echarts from 'echarts'

// vxe-table 样式
import VXETable from 'vxe-table'
import VXETablePluginExportXLSX from 'vxe-table-plugin-export-xlsx'
import 'vxe-table/lib/style.css'

// 公共样式
import '@/styles/index.scss' // global css

import App from './App'
import store from './store'
import router from './router'

import i18n from './lang' // internationalization
import './icons' // icon
import './permission' // permission control
import './utils/error-log' // error log
import './utils/filter' // global filter

import * as filters from './filters' // global filters

import signalR from '@/utils/signalR'

/**
 * If you don't want to use mock-server
 * you want to use MockJs for mock api
 * you can execute: mockXHR()
 *
 * Currently MockJs will be used in the production environment,
 * please remove it before going online ! ! !
 */

import '@/assets/iconfont/iconfont.css' // 第三方图标 -iconfont

import '@/assets/icommoon/icomoon.css' // 第三方图标 -icommoon

Vue.use(ElementUI, {
  size: Cookies.get('size') || 'small', // set element-ui default size
  i18n: (key, value) => i18n.t(key, value)
})

Vue.use(VXETable)
VXETable.use(VXETablePluginExportXLSX)

VXETable.setup({
  i18n: (key, args) => i18n.t(key, args)
})

// register global utility filters
Object.keys(filters).forEach(key => {
  Vue.filter(key, filters[key])
})

import htmlToPdf from '@/utils/htmlToPdf'
Vue.use(htmlToPdf)

Vue.prototype.$echarts = echarts

Vue.prototype.$XPrint = VXETable.print;

Vue.config.productionTip = false

signalR.init(process.env.VUE_APP_BASE_API+process.env.VUE_APP_SOCKET_API);
Vue.prototype.signalr = signalR

new Vue({
  el: '#app',
  router,
  store,
  i18n,
  render: h => h(App)
})
