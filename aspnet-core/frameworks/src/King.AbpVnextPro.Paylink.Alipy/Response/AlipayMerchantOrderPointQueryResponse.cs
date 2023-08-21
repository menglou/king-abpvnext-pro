﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantOrderPointQueryResponse.
    /// </summary>
    public class AlipayMerchantOrderPointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 所查询积分类型的积分余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }
    }
}
