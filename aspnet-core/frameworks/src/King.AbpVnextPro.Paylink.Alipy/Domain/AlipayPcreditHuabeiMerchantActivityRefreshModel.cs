﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMerchantActivityRefreshModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMerchantActivityRefreshModel : AlipayObject
    {
        /// <summary>
        /// 商家活动ID，用于唯一确定一个活动
        /// </summary>
        [JsonPropertyName("aggr_id")]
        public string AggrId { get; set; }

        /// <summary>
        /// 外部请求号,用于幂等管理
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
