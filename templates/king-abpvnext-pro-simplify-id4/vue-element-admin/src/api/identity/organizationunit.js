import request from '@/utils/request'

//添加组织
export function addRootOrganization(param) {
  return request({
    url: '/api/identity/organizations',
    method: 'post',
    data: param
  })
}

//更新组织
export function updateOrganization(id, payload) {
  return request({
    url: `/api/identity/organizations/${id}`,
    method: 'put',
    data: payload
  })
}
//删除组织
export function deleteOrganization(id) {
  return request({
    url: `/api/identity/organizations/${id}`,
    method: 'delete'
  })
}

//移动当前组织到某个组织喜爱按
export function moveOrganization(data) {
  return request({
    url: `/api/identity/organizations/move`,
    method: 'put',
    params: data
  })
}

//获取树形组织数据
export function GetOrganizationunitForTree() {
  return request({
    url: `/api/identity/organizations/all/details`,
    method: 'get'
  })
}
//根据组织id 获取下面的所有的用户 分页
export function getuseinorganizationunis(data) {
  return request({
    url: `/api/identity/organizations/users`,
    method: 'get',
    params:data
  })
}

//获取所有的组织list 不存在上下级关系的
export function getallOrganization() {
  return request({
    url: `/api/identity/organizations/allorglist`,
    method: 'get',
  })
}



//根据id 获取单个组织的详细信息
export function getorginfobyid(id) {
  return request({
    url: `/api/identity/organizations/${id}`,
    method: 'get'
  })
}
