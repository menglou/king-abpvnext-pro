﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignauditQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignauditQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
