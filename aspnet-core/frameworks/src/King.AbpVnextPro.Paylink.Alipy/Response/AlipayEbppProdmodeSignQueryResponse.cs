﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppProdmodeSignQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeSignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回签约信息数据对象，主要包含:产品编码、产品版本、生效时间、到期时间等
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<SignResultValue> DataList { get; set; }
    }
}
