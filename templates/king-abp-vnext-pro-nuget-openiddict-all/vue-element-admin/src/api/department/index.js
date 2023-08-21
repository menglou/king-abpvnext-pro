import request from '@/utils/request'

export function getdepartmentpagelist(data) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/details`,
    method: 'get',
    params: data
  })
}
export function getdepartmentalllist(data) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/all/details`,
    method: 'get',
    params: data
  })
}

export function adddepartment(data) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit`,
    method: 'post',
    data: data
  })
}

export function deletedepartment(id) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/${id}`,
    method: 'delete',
  })
}

export function getdepartmentUnit(id) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/${id}`,
    method: 'get'
  })
}

export function getalldepartmentUnit() {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/alldepartmentlist`,
    method: 'get'
  })
}

export function editdepartmentUnit(id, data) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/${id}`,
    method: 'put',
    data: data
  })
}

export function movedepartmentUnit(data) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/move`,
    method: 'put',
    params: data
  })
}

//根据id 获取下面的所有的用户 分页
export function getdepartmentuser(data) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/users`,
    method: 'get',
    params:data
  })
}

export function batchadduserToDep(data) {
  return request({
      url: `/api/DepartmentUnits/departmentUnit/batch-add-user-departmentunit`,
      method: 'post',
      data: data
  })
}

//根据id 获取下面的所有的用户 分页
export function getdepartmentuserbyid(id) {
  return request({
    url: `/api/DepartmentUnits/departmentUnit/depusers/${id}`,
    method: 'get'
  })
}