﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodPolicyApplyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodPolicyApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 车险询价申请号
        /// </summary>
        [JsonPropertyName("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonPropertyName("quote_biz_id")]
        public string QuoteBizId { get; set; }

        /// <summary>
        /// 车险订单交易信息
        /// </summary>
        [JsonPropertyName("trade_infos")]
        public List<InsTradeInfo> TradeInfos { get; set; }

        /// <summary>
        /// 吱口令
        /// </summary>
        [JsonPropertyName("zhi_link")]
        public string ZhiLink { get; set; }
    }
}
