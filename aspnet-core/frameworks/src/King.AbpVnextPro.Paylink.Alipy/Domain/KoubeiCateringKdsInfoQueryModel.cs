﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringKdsInfoQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringKdsInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// kdsID
        /// </summary>
        [JsonPropertyName("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
