﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayKeyQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayKeyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝脱机交易公钥列表。列表中每一项为一个有效的支付宝公钥信息, 其中id字段表示支付宝公钥id。
        /// </summary>
        [JsonPropertyName("keys")]
        public List<AlipayOfflinePayMasterKey> Keys { get; set; }
    }
}
