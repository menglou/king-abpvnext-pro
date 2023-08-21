﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailItemQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailItemQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码，6位国际码
        /// </summary>
        [JsonPropertyName("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 支付宝商品ID，即展示的券
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
