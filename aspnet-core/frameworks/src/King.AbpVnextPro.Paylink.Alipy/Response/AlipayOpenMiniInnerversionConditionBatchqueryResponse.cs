﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionConditionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionConditionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序版本信息
        /// </summary>
        [JsonPropertyName("mini_version_base_info_list")]
        public List<MiniVersionBaseInfo> MiniVersionBaseInfoList { get; set; }
    }
}
