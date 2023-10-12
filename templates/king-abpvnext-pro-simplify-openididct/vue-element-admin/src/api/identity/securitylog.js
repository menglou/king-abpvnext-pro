
import request from '@/utils/request'

export function getSecurityLogs(query) {
  return request({
    url: `/api/security-log/security-logs`,
    method: 'get',
    params: query
  })
}
