﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AnttechBlockchainFinancePfPaymentQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinancePfPaymentQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务参考号
        /// </summary>
        [JsonPropertyName("buss_refr_no")]
        public string BussRefrNo { get; set; }

        /// <summary>
        /// 支用标识
        /// </summary>
        [JsonPropertyName("financing_id")]
        public string FinancingId { get; set; }

        /// <summary>
        /// 平台标识
        /// </summary>
        [JsonPropertyName("platform_id")]
        public string PlatformId { get; set; }
    }
}
