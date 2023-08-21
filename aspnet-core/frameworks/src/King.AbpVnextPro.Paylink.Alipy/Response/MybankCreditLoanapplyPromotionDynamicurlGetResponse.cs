﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditLoanapplyPromotionDynamicurlGetResponse.
    /// </summary>
    public class MybankCreditLoanapplyPromotionDynamicurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// 推广活动需要跳转的动态链接地址
        /// </summary>
        [JsonPropertyName("dynamic_url")]
        public string DynamicUrl { get; set; }
    }
}
