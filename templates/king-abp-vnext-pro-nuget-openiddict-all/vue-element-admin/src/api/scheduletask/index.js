import request from '@/utils/request'

export function getscheduletaskpagelist(data) {
  return request({
    url: `/api/schedule-task/schedule`,
    method: 'get',
    params:data
  })
}

export function addscheduletask(data) {
  return request({
    url: `/api/schedule-task/schedule`,
    method: 'post',
    data:data
  })
}

export function pausescheduletask(sid) {
  return request({
    url: `/api/schedule-task/schedule/pause/${sid}`,
    method: 'get',
  })
}

export function startscheduletask(sid) {
  return request({
    url: `/api/schedule-task/schedule/start/${sid}`,
    method: 'get',
  })
}

export function runoncescheduletask(sid) {
  return request({
    url: `/api/schedule-task/schedule/runonce/${sid}`,
    method: 'get',
  })
}

export function resumescheduletask(sid) {
  return request({
    url: `/api/schedule-task/schedule/resume/${sid}`,
    method: 'get',
  })
}

export function stopscheduletask(sid) {
  return request({
    url: `/api/schedule-task/schedule/stop/${sid}`,
    method: 'get',
  })
}

export function deletescheduletask(sid) {
  return request({
    url: `/api/schedule-task/schedule/${sid}`,
    method: 'delete',
  })
}

export function getscheduleinfo(id) {
  return request({
    url: `/api/schedule-task/schedule/${id}`,
    method: 'get'
  })
}

export function editscheduletask(data) {
  return request({
    url: `/api/schedule-task/schedule`,
    method: 'put',
    data: data
  })
}

export function getschedulelogpagelist(data) {
  return request({
    url: `/api/schedule-task/schedule/log`,
    method: 'get',
    params:data
  })
}