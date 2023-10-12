import request from '@/utils/request'

export function resetpassword(data) {
  return request({
    url: `/api/account/reset-password`,
    method: 'post',
    data: data
  })
}
