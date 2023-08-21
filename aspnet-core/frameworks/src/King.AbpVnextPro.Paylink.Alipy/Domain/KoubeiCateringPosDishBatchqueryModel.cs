﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDishBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 菜谱的ID
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 按照菜品名字模糊查询菜谱下的菜品
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
