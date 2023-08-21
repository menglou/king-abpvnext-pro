﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ConsumeInfo Data Structure.
    /// </summary>
    public class ConsumeInfo : AlipayObject
    {
        /// <summary>
        /// 领取时间
        /// </summary>
        [JsonPropertyName("taken_time")]
        public string TakenTime { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 面额（单位分）
        /// </summary>
        [JsonPropertyName("voucher_amt")]
        public string VoucherAmt { get; set; }
    }
}
