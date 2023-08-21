﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeProductCreateResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeProductCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建成功生成的productId
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }
    }
}
