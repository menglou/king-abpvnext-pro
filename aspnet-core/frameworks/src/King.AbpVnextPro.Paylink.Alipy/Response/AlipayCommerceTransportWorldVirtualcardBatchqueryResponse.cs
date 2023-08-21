﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportWorldVirtualcardBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportWorldVirtualcardBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 虚拟卡信息查询结果列表
        /// </summary>
        [JsonPropertyName("card_models")]
        public List<AlipayQueryCardModelResult> CardModels { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("sub_error_code")]
        public string SubErrorCode { get; set; }
    }
}
