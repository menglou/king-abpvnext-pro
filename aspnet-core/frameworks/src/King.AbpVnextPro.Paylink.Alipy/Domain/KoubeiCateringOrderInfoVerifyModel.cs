﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoVerifyModel Data Structure.
    /// </summary>
    public class KoubeiCateringOrderInfoVerifyModel : AlipayObject
    {
        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户核销码中的核销数值串
        /// </summary>
        [JsonPropertyName("verify_order_id")]
        public string VerifyOrderId { get; set; }
    }
}
