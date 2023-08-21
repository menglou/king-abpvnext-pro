﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockApisdkgrayQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockApisdkgrayQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 测试接口参数随便配置
        /// </summary>
        [JsonPropertyName("output_param")]
        public string OutputParam { get; set; }
    }
}
