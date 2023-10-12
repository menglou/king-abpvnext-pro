import request from '@/utils/request'
import qs from 'querystring'

export function login(data) {
  return request({
    baseURL: process.env.VUE_APP_BASE_API,
    url: '/connect/token',
    //url: '/api/verification/Login',
    method: 'post',
    headers: { 'content-type': 'application/x-www-form-urlencoded' },
    data: qs.stringify(data)
  })
}

export function getInfo() {
  return request({
    url: '/api/account/my-profile',
    method: 'get'
  })
}

export function logout() {
  return request({
    baseURL: process.env.VUE_APP_BASE_API,
    url: '/connect/logout',
    method: 'get'
  })
}

export function register(data) {
  return request({
    url: '/api/account/register',
    method: 'post',
    data: data
  })
}

export function setUserInfo(data) {
  return request({
    url: '/api/account/my-profile',
    method: 'put',
    data: data
  })
}

export function changePassword(data) {
  return request({
    url: '/api/account/my-profile/change-password',
    method: 'post',
    data: data
  })
}

