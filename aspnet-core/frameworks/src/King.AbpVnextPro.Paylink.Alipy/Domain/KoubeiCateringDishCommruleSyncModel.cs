﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCateringDishCommruleSyncModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishCommruleSyncModel : AlipayObject
    {
        /// <summary>
        /// 规则列表 可批量操作
        /// </summary>
        [JsonPropertyName("kbdish_comm_rule_info_list")]
        public List<KbdishCommRuleInfo> KbdishCommRuleInfoList { get; set; }
    }
}
