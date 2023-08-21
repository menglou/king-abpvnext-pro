import request from '@/utils/request'

export function getposterpagelist(data) {
  return request({
    url: `/api/posters/poster`,
    method: 'get',
    params: data
  })
}
export function addposter(data) {
  return request({
    url: `/api/posters/poster`,
    method: 'post',
    data: data
  })
}
export function deleteposter(sid) {
  return request({
    url: `/api/posters/poster/${sid}`,
    method: 'delete'
  })
}
export function getposterinfo(id) {
  return request({
    url: `/api/posters/poster/${id}`,
    method: 'get'
  })
}
export function editposter(data) {
  return request({
    url: `/api/posters/poster`,
    method: 'put',
    data: data
  })
}

export function batchbinduserposter(data) {
  return request({
    url: `/api/posters/poster/batch-bind-user-poster`,
    method: 'post',
    data: data
  })
}

export function getposteruserbyid(id) {
  return request({
    url: `/api/posters/poster/posterusers/${id}`,
    method: 'get'
  })
}

