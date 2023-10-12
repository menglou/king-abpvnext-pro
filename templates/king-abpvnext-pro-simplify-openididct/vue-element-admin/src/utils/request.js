import axios from 'axios'
import { MessageBox, Message, Notification } from 'element-ui'
import store from '@/store'
import { param as encodeParam } from '@/utils'
import Vue from 'vue'

// create an axios instance
const service = axios.create({
  baseURL: process.env.VUE_APP_BASE_API, // url = base url + request url
  // withCredentials: true, // send cookies when cross-domain requests
  timeout: 300000 // request timeout
})
const whiteturl = ['/connect/token', '/api/abp/application-configuration', '/api/account/logout',
  '/api/identity/my-profile']
let loading
// 请求时的处理
function showloading() {
  loading = Vue.prototype.$loading({
    lock: true,
    text: 'Loading',
    spinner: 'el-icon-loading',
    background: 'rgba(0, 0, 0, 0.1)',
    target: document.querySelector('#app')
  })
}
function endLoading() {
  loading.close()
}

// 声明一个对象用于存储请求个数
let needLoadingRequestCount = 0
function showFullScreenLoading() {
  if (needLoadingRequestCount === 0) {
    showloading()
  }
  needLoadingRequestCount++
}
function tryHideFullScreenLoading() {
  if (needLoadingRequestCount <= 0) return
  needLoadingRequestCount--
  if (needLoadingRequestCount === 0) {
    endLoading()
  }
}
// request interceptor
service.interceptors.request.use(
  config => {
    // do something before request is sent
    config.headers['accept-language'] = store.getters.language

    if (store.getters.token) {
      config.headers['authorization'] = 'Bearer ' + store.getters.token
    }

    if (store.getters.tenant) {
      config.headers['__tenant'] = store.getters.tenant
    }
    if (config.isparam == undefined) {
      if (whiteturl.indexOf(config.url) == -1) {
        showFullScreenLoading()
      }
    } else {
      if (whiteturl.indexOf(config.whitleurl) == -1) {
        showFullScreenLoading()
      }
    }
    // config.paramsSerializer = function(params) {
    //   return encodeParam(params)
    // }

    return config
  },
  error => {
    // do something with request error
    console.log(error) // for debug
    return Promise.reject(error)
  }
)

// response interceptor
service.interceptors.response.use(
  response => {
    tryHideFullScreenLoading()
    const res = response.data
    return res
  },
  error => {
    tryHideFullScreenLoading()
    console.log(error) // for debug

    if (error.response.status === 401) {
      // to re-login
      MessageBox.confirm(
        '您已注销，您可以取消以留在此页面上，或者重新登录',
        '确认注销？',
        {
          confirmButtonText: '重新登录',
          cancelButtonText: '取消',
          type: 'warning'
        }
      ).then(() => {
        store.dispatch('user/resetToken').then(() => {
          location.reload()
        })
      })
    } else if (error.response.status === 403) {
      if (error.response && error.response.data && error.response.data.error && error.response.data.error.message) {
        Notification.error({
          message: error.response.data.error.message,
          title: '提示'
        })
      } else {
        Notification.error({
          message: '您没有权限访问,请联系管理员！',
          title: '提示'
        })
      }
    } else {
      tryHideFullScreenLoading()
      let message = ''
      if (error.response && error.response.data && error.response.data.error) {
        // if(response.config.url=="/connect/token"){
        //     message = error.response.data.error.message
        // }
        // else{
        //     message = error.response.data.error.message
        // }

        if (Object.prototype.toString.call(error.response.data.error) === '[object Object]') {
          message = error.response.data.error.message
        } else {
          message = error.response.data.error_description
        }

        if (error.response.data.error.details != undefined) {
          message += error.response.data.error.details
        }
      } else {
        message = error.message
        if (Object.prototype.toString.call(error.message) === '[object Object]') {
          message = error.message
        } else {
          message = error_description
        }
        if (error.details != undefined) {
          message += error.details
        }
      }
      if (message == '' || message == null || message == undefined) {
        Notification.error({
          message: '内部服务器错误',
          title: '提示'
        })
      } else {
        Notification.error({
          message: message,
          title: '提示'
        })
      }
    }
    return Promise.reject(error)
  }
)

export default service
