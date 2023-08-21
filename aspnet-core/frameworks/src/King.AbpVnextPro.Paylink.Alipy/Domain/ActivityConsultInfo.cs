﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ActivityConsultInfo Data Structure.
    /// </summary>
    public class ActivityConsultInfo : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 错误码：领取超限(RECEIVE_LIMIT_EXCEEDED)，券余量不足(VOUCHER_INSUFFICIENT_EXCEPTION)，活动未处于有效期内(ACTIVITY_NOT_IN_TIME_EXCEPTION)，通用领取异常(RECEIVE_FAIL_ERROR)
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否可领
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
