﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonPropertyName("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价返回信息
        /// </summary>
        [JsonPropertyName("quote_infos")]
        public List<QuoteInfo> QuoteInfos { get; set; }
    }
}
