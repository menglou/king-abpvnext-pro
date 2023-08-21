﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppYoukuvideoAuditcallbackSendModel Data Structure.
    /// </summary>
    public class AlipayOpenAppYoukuvideoAuditcallbackSendModel : AlipayObject
    {
        /// <summary>
        /// 审核后状态：allowed 审核通过，blocked 屏蔽驳回， censoring 审核中
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 审核前状态：allowed 审核通过，blocked 屏蔽驳回， censoring 审核中
        /// </summary>
        [JsonPropertyName("old_action")]
        public string OldAction { get; set; }

        /// <summary>
        /// 审核来源，1表示审核-一审、2表示审核-二审、3表示审核-三审、4表示审核-综合审、5表示审核-修改审， 30表示播控， 31表示版权解除屏蔽操作，32VMS解屏蔽,33表示视频替换 40表示来疯先发后审 41 表示来疯审核
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 视频ID
        /// </summary>
        [JsonPropertyName("vid")]
        public string Vid { get; set; }
    }
}
