import request from '@/utils/request'

export function sendandcreatenotice(data) {
  return request({
    url: `/api/notifications/notification/SendBroadCastInformationMessage`,
    method: 'post',
    data: data
  })
}

export function onlysendnotice(id) {
  return request({
    url: `/api/notifications/notification/SendOnlyBroadCastMessage/${id}`,
    method: 'get',
  })
}


export function getnoticepagelist(data) {
  return request({
    url: `/api/notifications/notification/BroadCastPageList`,
    method: 'get',
    params: data
  })
}

export function getBroadCastnoticelist(data) {
  return request({
    url: `/api/notifications/notification/BroadCastList`,
    method: 'get',
    params: data
  })
}

export function getcommonnoticelist(data) {
  return request({
    url: `/api/notifications/notification/CommonNotificationList`,
    method: 'get',
    params: data
  })
}

export function deleteBroadCastnotice(id) {
  return request({
    url: `/api/notifications/notification/DeleteBroadCast/${id}`,
    method: 'delete',
  })
}

export function updateBroadCastnotice(id, data) {
  return request({
    url: `/api/notifications/notification/UpdateBroadCast/${id}`,
    method: 'put',
    data: data
  })
}

export function setisread(data) {
  return request({
    url: `/api/notifications/notification/Read`,
    method: 'post',
    data: data
  })
}