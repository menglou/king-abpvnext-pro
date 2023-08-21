﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationOrderapplyCreateResponse.
    /// </summary>
    public class AlipayInsSceneApplicationOrderapplyCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 流水号
        /// </summary>
        [JsonPropertyName("biz_flow_no")]
        public string BizFlowNo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }
    }
}
