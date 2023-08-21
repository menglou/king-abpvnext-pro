﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderCreateResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 物料申请单号，即SO单号
        /// </summary>
        [JsonPropertyName("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }
    }
}
