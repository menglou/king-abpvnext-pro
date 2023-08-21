﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishGroupSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishGroupSyncModel : AlipayObject
    {
        /// <summary>
        /// 口碑菜品套餐项目组
        /// </summary>
        [JsonPropertyName("kb_dish_group")]
        public KbdishGroupInfo KbDishGroup { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;stateChange 状态变更,del 删除
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }
    }
}
