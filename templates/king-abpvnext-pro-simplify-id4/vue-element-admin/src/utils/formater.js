import XEUtils from 'xe-utils'

export function formatDate({ cellValue }, format) {
  return XEUtils.toDateString(cellValue, format || 'yyyy-MM-dd HH:mm:ss')
}

// 日期格式化
export function dateFormat(fmt, date) {
  let ret
  const opt = {
    'Y+': date.getFullYear().toString(), // 年
    'm+': (date.getMonth() + 1).toString(), // 月
    'd+': date.getDate().toString(), // 日
    'H+': date.getHours().toString(), // 时
    'M+': date.getMinutes().toString(), // 分
    'S+': date.getSeconds().toString() // 秒
    // 有其他格式化字符需求可以继续添加，必须转化成字符串
  }
  for (const k in opt) {
    ret = new RegExp('(' + k + ')').exec(fmt)
    if (ret) {
      fmt = fmt.replace(
        ret[1],
        ret[1].length == 1 ? opt[k] : opt[k].padStart(ret[1].length, '0')
      )
    }
  }
  return fmt
}

// 比较两个时间的大小
export function CompareDate(date1, date2) {
  var oDate1 = new Date(date1)
  var oDate2 = new Date(date2)
  if (oDate1.getTime() > oDate2.getTime()) {
    return true // 第一个大
  } else {
    return false // 第二个大
  }
}

// 两个日期相减获取天数
export function DateMinus(date1, date2) {
  debugger
  // date1:小日期   date2:大日期
  var sdate = new Date(date1)
  var now = new Date(date2)
  var days = now.getTime() - sdate.getTime()
  var day = parseInt(days / (1000 * 60 * 60 * 24))
  return day
}
export function datedifference(sDate1, sDate2) {    // sDate1和sDate2是2006-12-18格式
  var dateSpan,
    tempDate,
    iDays
  sDate1 = Date.parse(sDate1)
  sDate2 = Date.parse(sDate2)
  dateSpan = sDate2 - sDate1
  dateSpan = Math.abs(dateSpan)
  iDays = Math.floor(dateSpan / (24 * 3600 * 1000))
  return iDays
}

export function isEmpty(obj) {
  if (typeof obj === 'undefined' || obj == null || obj == '') {
    return true
  } else {
    return false
  }
}
