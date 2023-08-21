﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayFundBatchAppPayModel Data Structure.
    /// </summary>
    public class AlipayFundBatchAppPayModel : AlipayObject
    {
        /// <summary>
        /// 支付宝内部批次号
        /// </summary>
        [JsonPropertyName("batch_trans_id")]
        public string BatchTransId { get; set; }
    }
}
