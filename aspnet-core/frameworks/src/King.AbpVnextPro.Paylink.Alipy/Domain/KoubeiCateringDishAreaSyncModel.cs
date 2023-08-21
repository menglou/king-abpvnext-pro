﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishAreaSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishAreaSyncModel : AlipayObject
    {
        /// <summary>
        /// area:操作餐区模型 ;  tab:餐台列表; dish:操作开台菜列表    说明 修改全字段修改,设置为空则更新为空
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 口碑餐区模型。包含了餐台以及开台菜
        /// </summary>
        [JsonPropertyName("kb_dish_area")]
        public KbdishAreaInfo KbDishArea { get; set; }

        /// <summary>
        /// 同步类型: add 新增;update 修改;stateChange 状态变更,del 删除
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }
    }
}
