﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosDishgroupSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDishgroupSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回对应的组合菜ID
        /// </summary>
        [JsonPropertyName("dish_group_id")]
        public string DishGroupId { get; set; }
    }
}
