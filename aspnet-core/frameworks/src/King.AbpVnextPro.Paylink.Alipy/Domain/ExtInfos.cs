﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ExtInfos Data Structure.
    /// </summary>
    public class ExtInfos : AlipayObject
    {
        /// <summary>
        /// 唤起鉴权的页面类型；DETAIL表示商详页
        /// </summary>
        [JsonPropertyName("req_from_page")]
        public string ReqFromPage { get; set; }
    }
}
