﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeIndustryTradeQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息字段，格式:json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户扣款或退款时对应的资金单号
        /// </summary>
        [JsonPropertyName("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 签约产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [JsonPropertyName("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
