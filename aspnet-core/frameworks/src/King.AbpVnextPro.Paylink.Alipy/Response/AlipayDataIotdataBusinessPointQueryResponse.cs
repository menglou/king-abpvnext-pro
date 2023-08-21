﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointQueryResponse.
    /// </summary>
    public class AlipayDataIotdataBusinessPointQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 业务点位信息列表
        /// </summary>
        [JsonPropertyName("data")]
        public List<BusinessPoint> Data { get; set; }
    }
}
