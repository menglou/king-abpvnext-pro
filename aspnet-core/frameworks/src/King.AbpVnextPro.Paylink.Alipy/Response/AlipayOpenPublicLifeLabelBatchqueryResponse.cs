﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonPropertyName("labels")]
        public List<LifeLabel> Labels { get; set; }
    }
}
