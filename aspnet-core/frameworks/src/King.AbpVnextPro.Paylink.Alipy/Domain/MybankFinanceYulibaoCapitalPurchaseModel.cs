﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankFinanceYulibaoCapitalPurchaseModel Data Structure.
    /// </summary>
    public class MybankFinanceYulibaoCapitalPurchaseModel : AlipayObject
    {
        /// <summary>
        /// 余利宝申购金额，单位是“分”。如amount=123456表示申购1234.56元的余利宝份额。
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 金额对应的币种，目前仅支持CNY，即人民币。
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 基金代码。余利宝场景固定为 001529。
        /// </summary>
        [JsonPropertyName("fund_code")]
        public string FundCode { get; set; }

        /// <summary>
        /// 余利宝申购流水号，用于幂等控制。流水号必须长度在30到40位之间，且仅能由数字、字母、字符“-”和字符“_”组成。建议使用UUID，如“c39c24f1-73e5-497d-9b1f-0f585ae192c1”，或者使用自定义的数字流水号，如“201608150000000000000000000000000001”。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
