﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTravelContentCountSyncResponse.
    /// </summary>
    public class AlipayOverseasTravelContentCountSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 详细错误码。可选，当code=40004，sub_code=BUSINESS_ERROR，不为为空
        /// </summary>
        [JsonPropertyName("results")]
        public string Results { get; set; }
    }
}
