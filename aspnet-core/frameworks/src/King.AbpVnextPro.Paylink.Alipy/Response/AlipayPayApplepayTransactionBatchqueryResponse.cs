﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPayApplepayTransactionBatchqueryResponse.
    /// </summary>
    public class AlipayPayApplepayTransactionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonPropertyName("last_updated_tag")]
        public string LastUpdatedTag { get; set; }

        /// <summary>
        /// 头部
        /// </summary>
        [JsonPropertyName("response_header")]
        public BaseOpenApiResponseHeaderDTO ResponseHeader { get; set; }

        /// <summary>
        /// 支付记录列表
        /// </summary>
        [JsonPropertyName("transaction_details")]
        public List<TransactionDetailDTO> TransactionDetails { get; set; }
    }
}
