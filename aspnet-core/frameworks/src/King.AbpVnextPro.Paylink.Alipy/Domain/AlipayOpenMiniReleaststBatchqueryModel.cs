﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniReleaststBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniReleaststBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 20
        /// </summary>
        [JsonPropertyName("canshu")]
        public string Canshu { get; set; }

        /// <summary>
        /// 测试数据
        /// </summary>
        [JsonPropertyName("fuza")]
        public GavintestNewLeveaOne Fuza { get; set; }
    }
}
