import request from '@/utils/request'

export function getveriCode() {
  return request({
    url: `/api/verification/verification-code`,
    method: 'get'
  })
}

export function vertifyveriCode(id, code) {
  return request({
    url: `/api/verification/vertifyveriCode/${id}/${code}`,
    method: 'get',
    isparam: true,
    whitleurl: '/api/verification/vertifyveriCode'
  })
}
