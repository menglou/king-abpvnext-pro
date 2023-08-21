﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishCommruleSyncResponse.
    /// </summary>
    public class KoubeiCateringDishCommruleSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 新增返回的数据集合，如果是修改 或者删除 不返回
        /// </summary>
        [JsonPropertyName("kbdish_comm_rule_info_list")]
        public List<KbdishCommRuleInfo> KbdishCommRuleInfoList { get; set; }
    }
}
