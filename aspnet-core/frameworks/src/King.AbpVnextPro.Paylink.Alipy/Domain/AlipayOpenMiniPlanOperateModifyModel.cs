﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniPlanOperateModifyModel : AlipayObject
    {
        /// <summary>
        /// 小程序投放方案场景码，目前只支持传入支付后推荐场景码：PAYMENT_SUCCESS
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 目前只支持小程序和生活号类型的优先级调整，若需要调整小程序优先，请传TINYAPP,PUBLICAPP；若需要调整生活号优先，请传PUBLICAPP,TINYAPP
        /// </summary>
        [JsonPropertyName("type_list")]
        public string TypeList { get; set; }
    }
}
