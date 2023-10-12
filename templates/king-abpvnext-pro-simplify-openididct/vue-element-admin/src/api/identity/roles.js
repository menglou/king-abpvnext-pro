import request from '@/utils/request'

export function getAllRoles() {
  return request({
    url: '/api/identity/roles/all',
    method: 'get'
  })
}

export function getRolesList(data) {
  return request({
    url: '/api/identity/roles',
    method: 'get',
    params: data
  })
}

export function addroleinfo(data) {
  return request({
    url: '/api/identity/roles',
    method: 'post',
    data: data
  })
}

export function updateroleinfo(id, data) {
  return request({
    url: `/api/identity/roles/${id}`,
    method: 'put',
    data: data
  })
}

export function getroleinfo(id) {
  return request({
    url: `/api/identity/roles/${id}`,
    method: 'get'
  })
}
