﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDishSyncModel : AlipayObject
    {
        /// <summary>
        /// 自建盒子菜品的模型
        /// </summary>
        [JsonPropertyName("pos_dish_model")]
        public PosDishModel PosDishModel { get; set; }
    }
}
