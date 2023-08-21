﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOverseasTravelRateBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelRateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 货币代码列表，货币代码遵循ISO标准alpha- 3币种代码，用英文半角逗号分隔，支持的币种可以联系支付宝技术支持。
        /// </summary>
        [JsonPropertyName("currencies")]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// 业务扩展参数,用于商户的特 定业务信息的传递,json格式
        /// </summary>
        [JsonPropertyName("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
