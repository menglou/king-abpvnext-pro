﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsSceneProductSignConfirmModel Data Structure.
    /// </summary>
    public class AlipayInsSceneProductSignConfirmModel : AlipayObject
    {
        /// <summary>
        /// 产品编码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 支付宝会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
