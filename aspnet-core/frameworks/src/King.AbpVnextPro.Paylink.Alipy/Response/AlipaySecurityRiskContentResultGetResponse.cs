﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentResultGetResponse.
    /// </summary>
    public class AlipaySecurityRiskContentResultGetResponse : AlipayResponse
    {
        /// <summary>
        /// 命中结果详情
        /// </summary>
        [JsonPropertyName("hit_detect_items")]
        public List<InfoSecHitDetectItem> HitDetectItems { get; set; }

        /// <summary>
        /// PASSED("数据识别通过，可以在网站上正常显示")    REJECTED("被拒绝的数据，比如内容出现违禁词；不能出现在我们网站上")
        /// </summary>
        [JsonPropertyName("result_action")]
        public string ResultAction { get; set; }

        /// <summary>
        /// 输出命中的标签，用逗号分割
        /// </summary>
        [JsonPropertyName("risk_labels")]
        public string RiskLabels { get; set; }
    }
}
