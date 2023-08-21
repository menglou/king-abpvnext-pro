﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundAccountbookQueryResponse.
    /// </summary>
    public class AlipayFundAccountbookQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 记账账簿id
        /// </summary>
        [JsonPropertyName("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        [JsonPropertyName("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 场景余额模式外标卡信息
        /// </summary>
        [JsonPropertyName("ext_card_info")]
        public ExtCardInfo ExtCardInfo { get; set; }
    }
}
