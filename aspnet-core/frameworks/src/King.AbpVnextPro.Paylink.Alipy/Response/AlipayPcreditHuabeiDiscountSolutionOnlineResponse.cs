﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOnlineResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionOnlineResponse : AlipayResponse
    {
        /// <summary>
        /// 贴息方案实例id
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }

        /// <summary>
        /// 贴息方案是否生效，true生效，false没有生效
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
