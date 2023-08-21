﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiMemberDataDesdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("desd")]
        public GavintestNewLeveaOne Desd { get; set; }
    }
}
