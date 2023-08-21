﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingDataSceneTravelGetResponse.
    /// </summary>
    public class KoubeiMarketingDataSceneTravelGetResponse : AlipayResponse
    {
        /// <summary>
        /// 场景营销内容分组场景营
        /// </summary>
        [JsonPropertyName("content")]
        public List<SceneMarketingContentGroup> Content { get; set; }

        /// <summary>
        /// 场景营销头部信息
        /// </summary>
        [JsonPropertyName("header")]
        public SceneMarketingHeader Header { get; set; }
    }
}
