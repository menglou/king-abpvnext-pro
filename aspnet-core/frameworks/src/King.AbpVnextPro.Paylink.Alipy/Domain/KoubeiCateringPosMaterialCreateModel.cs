﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosMaterialCreateModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosMaterialCreateModel : AlipayObject
    {
        /// <summary>
        /// 配料名称
        /// </summary>
        [JsonPropertyName("material_name")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 商户门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
