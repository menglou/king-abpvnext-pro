﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsCooperationProductOfflineBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayInsCooperationProductOfflineBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 机构在蚂蚁平台上的惟一标识
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }
    }
}
