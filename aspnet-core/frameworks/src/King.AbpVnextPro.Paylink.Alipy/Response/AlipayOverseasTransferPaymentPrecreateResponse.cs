﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTransferPaymentPrecreateResponse.
    /// </summary>
    public class AlipayOverseasTransferPaymentPrecreateResponse : AlipayResponse
    {
        /// <summary>
        /// pass_through_info
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// transfer_id
        /// </summary>
        [JsonPropertyName("transfer_id")]
        public string TransferId { get; set; }
    }
}
