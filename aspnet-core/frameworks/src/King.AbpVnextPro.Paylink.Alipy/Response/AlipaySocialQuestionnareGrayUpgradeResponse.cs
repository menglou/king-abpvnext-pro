﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialQuestionnareGrayUpgradeResponse.
    /// </summary>
    public class AlipaySocialQuestionnareGrayUpgradeResponse : AlipayResponse
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 调整后的灰度值
        /// </summary>
        [JsonPropertyName("gray_percent")]
        public string GrayPercent { get; set; }

        /// <summary>
        /// 哥伦布问券任务Id
        /// </summary>
        [JsonPropertyName("qstn_id")]
        public string QstnId { get; set; }
    }
}
