﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ErrorDishEntity Data Structure.
    /// </summary>
    public class ErrorDishEntity : AlipayObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonPropertyName("dish_name")]
        public string DishName { get; set; }
    }
}
