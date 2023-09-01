import request from '@/utils/request'

export function uploadfile(data) {
  return request({
    url: `/api/file-management/files/upload`,
    method: 'post',
    data: data
  })
}

export function deletefile(blobName) {
  return request({
    url: `/api/file-management/files/${blobName}`,
    method: 'delete',
  })
}

export function getfileinfo(blobName) {
  return request({
    url: `/api/file-management/files/${blobName}`,
    method: 'get'
  })
}