﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppIndustryGovHealthcodeQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryGovHealthcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 码的颜色，红/黄/绿/审核中，分别对应如下: red/yellow/green/init,
        /// </summary>
        [JsonPropertyName("code_color")]
        public string CodeColor { get; set; }

        /// <summary>
        /// 生成的健康码码值
        /// </summary>
        [JsonPropertyName("code_content")]
        public string CodeContent { get; set; }

        /// <summary>
        /// 码值刷新的时间，可能为空
        /// </summary>
        [JsonPropertyName("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
