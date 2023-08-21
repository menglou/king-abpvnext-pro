﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserAccountSearchResponse.
    /// </summary>
    public class AlipayUserAccountSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户账务明细信息
        /// </summary>
        [JsonPropertyName("account_records")]
        public List<AccountRecord> AccountRecords { get; set; }

        /// <summary>
        /// 总页面数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_results")]
        public long TotalResults { get; set; }
    }
}
