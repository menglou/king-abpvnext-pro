﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorGetResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieEditorGetResponse : AlipayResponse
    {
        /// <summary>
        /// 唤起云凤蝶站点编辑器返回模型，包含 编辑器具体免登的url
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieEditorGetRespModel Data { get; set; }
    }
}
