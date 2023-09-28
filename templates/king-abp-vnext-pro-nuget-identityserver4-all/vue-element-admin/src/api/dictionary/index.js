import request from '@/utils/request'

export function adddictionary(data) {
    return request({
        url: `/api/data-dictionary/dictionary`,
        method: 'post',
        data: data
    })
}

export function getdictionarypagelist(data) {
    return request({
        url: `/api/data-dictionary/dictionary`,
        method: 'get',
        params: data
    })
}

export function getdictionaryinfo(id) {
    return request({
        url: `/api/data-dictionary/dictionary/${id}`,
        method: 'get'
    })
}

export function editdictionaryinfo(id, data) {
    return request({
        url: `/api/data-dictionary/dictionary/${id}`,
        method: 'put',
        data: data
    })
}

export function deletedictionaryinfo(id) {
    return request({
        url: `/api/data-dictionary/dictionary/${id}`,
        method: 'delete'
    })
}




//以下是字典详情的
export function getdictionarydetailpagelist(data) {
    return request({
        url: `/api/data-dictionary-detail/dictionary-detail`,
        method: 'get',
        params: data
    })
}



export function adddictionarydetail(data) {
    return request({
        url: `/api/data-dictionary-detail/dictionary-detail`,
        method: 'post',
        data: data
    })
}
export function editdictionarydetail(id, data) {
    return request({
        url: `/api/data-dictionary-detail/dictionary-detail/${id}`,
        method: 'put',
        data: data
    })
}
export function deletedictionarydetail(id) {
    return request({
        url: `/api/data-dictionary-detail/dictionary-detail/${id}`,
        method: 'delete'
    })
}

export function getdictionarydetailifo(id) {
    return request({
        url: `/api/data-dictionary-detail/dictionary-detail/${id}`,
        method: 'get'
    })
}

//根据字典id获取字典详情
export function getdictionarydetailpagelistbyId(data) {
    return request({
        url: `/api/data-dictionary-detail/dictionary-detail/getDetailListBydtId`,
        method: 'get',
        params: data
    })
}