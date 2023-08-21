import request from '@/utils/request'

export function getuserinfobyusername(username) {
  return request({
    url: `/api/identity/users/by-username/${username}`,
    method: 'get'
  })
}
// 获取用户列表
export function getuserlist(data) {
  return request({
    url: '/api/identity/users',
    method: 'get',
    params: data
  })
}
// 获取所有的用户
export function getalluserlist() {
  return request({
    url: `/api/identity/users/allusers`,
    method: 'get'
  })
}
// 添加用户并添加用户组织的接口
export function addusertoorganization(data) {
  return request({
    url: `/api/identity/users/create-to-organizations`,
    method: 'post',
    data: data
  })
}
// 单独添加用户 不带组织
export function adduserinfo(data) {
  return request({
    url: '/api/identity/users',
    method: 'post',
    data: data
  })
}

// 添加用户到组织
export function adduserToOrg(userId, data) {
  return request({
    url: `/api/identity/users/${userId}/add-to-organizations`,
    method: 'post',
    data: data
  })
}

// 批量添加用户到组织
export function batchadduserToOrg(data) {
  return request({
    url: `/api/identity/users/batch-add-to-organizations`,
    method: 'post',
    data: data
  })
}
// 更新用户信息带组织的
export function updateuserToOrg(id, data) {
  return request({
    url: `/api/identity/users/${id}/update-to-organizations`,
    method: 'put',
    data: data
  })
}

// 移除组织下的用户
export function removeuserinOrg(data) {
  return request({
    url: `/api/identity/users/removeuserinorganizations`,
    method: 'delete',
    params: data
  })
}
// 根据用户id获取用户信息
export function getuserinfobyid(id) {
  return request({
    url: `/api/identity/users/${id}`,
    method: 'get'
  })
}
// 根据用户id获取组织信息
export function getorganizationbyid(id) {
  return request({
    url: `/api/identity/users/${id}/organizations`,
    method: 'get',
    params: {
      includeDetails: false
    }
  })
}
// 根据用户id获取角色信息
export function getrolesbyid(id) {
  return request({
    url: `/api/identity/users/${id}/roles`,
    method: 'get'
  })
}

// 解锁/锁住
export function updateuserlockinfo(id) {
  return request({
    url: `/api/identity/users/unlockuser/${id}`,
    method: 'put'
  })
}

// 冻结/激活
export function updateuseractiveinfo(data) {
  return request({
    url: `/api/identity/users/updateuseractive`,
    method: 'put',
    data: data
  })
}

// 删除用户
export function deleteuserinfo(userid) {
  return request({
    url: `/api/identity/users/deleteuser/${userid}`,
    method: 'delete'
  })
}

