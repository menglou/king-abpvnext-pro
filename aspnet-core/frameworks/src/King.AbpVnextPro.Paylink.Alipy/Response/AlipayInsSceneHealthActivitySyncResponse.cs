﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneHealthActivitySyncResponse.
    /// </summary>
    public class AlipayInsSceneHealthActivitySyncResponse : AlipayResponse
    {
        /// <summary>
        /// 申请编号，成功返回原申请编号，失败为空
        /// </summary>
        [JsonPropertyName("apply_no")]
        public string ApplyNo { get; set; }
    }
}
