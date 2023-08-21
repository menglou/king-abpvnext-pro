﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.WeChat.V3.Domain
{
    /// <summary>
    /// 合单下单子单信息
    /// </summary>       
    public class CombineSubOrderInfoResponse : WeChatPayObject
    {
        /// <summary>
        /// 子单商户号
        /// </summary>
        /// <remarks>
        /// 子单发起方商户号，必须与发起方appid有绑定关系。
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("mchid")]
        public string MchId { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// NATIVE：扫码支付
        /// JSAPI：公众号支付
        /// APP：APP支付
        /// MWEB：H5支付
        /// <para>示例值：JSAPI</para>
        /// </remarks>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// SUCCESS：支付成功
        /// REFUND：转入退款
        /// NOTPAY：未支付
        /// CLOSED：已关闭
        /// USERPAYING：用户支付中（付款码支付）
        /// PAYERROR：支付失败(其他原因，如银行返回失败)
        /// <para>示例值：SUCCESS</para>
        /// </remarks>
        [JsonPropertyName("trade_state")]
        public string TradeState { get; set; }

        /// <summary>
        /// 付款银行
        /// </summary>
        /// <remarks>
        /// 银行类型，采用字符串类型的银行标识。
        /// <para>示例值：CMC</para>
        /// </remarks>
        [JsonPropertyName("bank_type")]
        public string BankType { get; set; }

        /// <summary>
        /// 附加数据
        /// </summary>
        /// <remarks>
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用。
        /// <para>示例值：深圳分店</para>
        /// </remarks>
        [JsonPropertyName("attach")]
        public string Attach { get; set; }

        /// <summary>
        /// 支付完成时间
        /// </summary>
        /// <remarks>
        /// 订单支付时间，遵循rfc3339标准格式，格式为YYYY-MM-DDTHH:mm:ss:sss+TIMEZONE，YYYY-MM-DD表示年月日，T出现在字符串中，表示time元素的开头，HH:mm:ss:sss表示时分秒毫秒，TIMEZONE表示时区（+08:00表示东八区时间，领先UTC 8小时，即北京时间）。例如：2015-05-20T13:29:35+08:00表示，北京时间2015年5月20日13点29分35秒。
        /// <para>示例值：2015-05-20T13:29:35.120+08:00</para>
        /// </remarks>
        [JsonPropertyName("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        /// <remarks>
        /// 微信支付订单号。
        /// <para>示例值：1009660380201506130728806387</para>
        /// </remarks>
        [JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 子单商户订单号
        /// </summary>
        /// <remarks>
        /// 商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*@ ，且在同一个商户号下唯一。
        /// 特殊规则：最小字符长度为6
        /// <para>示例值：20150806125346</para>
        /// </remarks>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 二级商户号
        /// </summary>
        /// <remarks>
        /// 二级商户商户号，由微信支付生成并下发。
        /// 注意：仅适用于电商平台 服务商
        /// <para>示例值：1900000109</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        /// <remarks>
        /// 订单金额信息
        /// </remarks>
        [JsonPropertyName("amount")]
        public CombineAmount Amount { get; set; }

        /// <summary>
        /// 优惠功能
        /// </summary>
        /// <remarks>
        /// 优惠功能，子单有核销优惠券时有返回
        /// </remarks>
        [JsonPropertyName("promotion_detail")]
        public PromotionDetail PromotionDetail { get; set; }
    }
}
