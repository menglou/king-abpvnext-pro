﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDishQueryModel : AlipayObject
    {
        /// <summary>
        /// 菜品的ID
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 门店的ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
