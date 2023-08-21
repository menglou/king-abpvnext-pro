﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDishgroupSyncModel : AlipayObject
    {
        /// <summary>
        /// 组合菜详情
        /// </summary>
        [JsonPropertyName("pos_dish_group_model")]
        public PosDishGroupModel PosDishGroupModel { get; set; }
    }
}
