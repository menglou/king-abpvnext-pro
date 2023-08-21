﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditPeUserOrderSyncResponse.
    /// </summary>
    public class ZhimaCreditPeUserOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 外部请求幂等号，即接口入参的out_request_no，接口处理完之后回传
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务处理是否成功标记，成功返回true，其他情况下返回false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
