﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAssetPointOrderCreateModel Data Structure.
    /// </summary>
    public class AlipayAssetPointOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 向用户展示集分宝发放备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// isv提供的发放订单号，由数字和字母组成，最大长度为32位，需要保证每笔订单发放的唯一性，支付宝对该参数做唯一性校验。如果订单号已存在，支付宝将返回订单号已经存在的错误
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 发放集分宝时间
        /// </summary>
        [JsonPropertyName("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 发放集分宝的数量
        /// </summary>
        [JsonPropertyName("point_count")]
        public long PointCount { get; set; }

        /// <summary>
        /// 用户标识符，用于指定集分宝发放的用户，和user_symbol_type一起使用，确定一个唯一的支付宝用户
        /// </summary>
        [JsonPropertyName("user_symbol")]
        public string UserSymbol { get; set; }

        /// <summary>
        /// 用户标识符类型，  现在支持ALIPAY_USER_ID:表示支付宝用户ID,  ALIPAY_LOGON_ID:表示支付宝登陆号,  TAOBAO_NICK:淘宝昵称
        /// </summary>
        [JsonPropertyName("user_symbol_type")]
        public string UserSymbolType { get; set; }
    }
}
