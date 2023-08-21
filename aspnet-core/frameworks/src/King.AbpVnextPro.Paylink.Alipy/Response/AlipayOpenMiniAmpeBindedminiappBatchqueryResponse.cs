﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAmpeBindedminiappBatchqueryResponse.
    /// </summary>
    public class AlipayOpenMiniAmpeBindedminiappBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 绑定的小程序信息列表
        /// </summary>
        [JsonPropertyName("binded_mini_app_list")]
        public List<BindedMiniAppInfo> BindedMiniAppList { get; set; }

        /// <summary>
        /// 已绑定小程序的总个数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
