﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ContributeDetail Data Structure.
    /// </summary>
    public class ContributeDetail : AlipayObject
    {
        /// <summary>
        /// 出资方金额
        /// </summary>
        [JsonPropertyName("contribute_amount")]
        public string ContributeAmount { get; set; }

        /// <summary>
        /// 出资方类型，如品牌商出资、支付宝平台出资等
        /// </summary>
        [JsonPropertyName("contribute_type")]
        public string ContributeType { get; set; }
    }
}
