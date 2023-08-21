﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayTradePagePayModel Data Structure.
    /// </summary>
    public class AlipayTradePagePayModel : AlipayObject
    {
        /// <summary>
        /// 签约参数，支付后签约场景使用
        /// </summary>
        [JsonPropertyName("agreement_sign_params")]
        public AgreementSignParams AgreementSignParams { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割 注，与enable_pay_channels互斥 <a href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>
        /// </summary>
        [JsonPropertyName("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分割。 与disable_pay_channels互斥，支持传入的值：<a target="_blank" href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>。 注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。
        /// </summary>
        [JsonPropertyName("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 外部指定买家
        /// </summary>
        [JsonPropertyName("ext_user_info")]
        public ExtUserInfo ExtUserInfo { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式。
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// 商品主类型 ，枚举支持： 0：虚拟类商品； 1：实物类商品。 注：虚拟类商品不支持使用花呗渠道
        /// </summary>
        [JsonPropertyName("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// 请求后页面的集成方式。 枚举值： ALIAPP：支付宝钱包内 PCWEB：PC端访问 默认值为PCWEB。
        /// </summary>
        [JsonPropertyName("integration_type")]
        public string IntegrationType { get; set; }

        /// <summary>
        /// 开票信息
        /// </summary>
        [JsonPropertyName("invoice_info")]
        public InvoiceInfo InvoiceInfo { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数。 如果请求时传递了该参数，支付宝会在异步通知时将该参数原样返回。 本参数必须进行UrlEncode之后才可以发送给支付宝。
        /// </summary>
        [JsonPropertyName("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： <a target="_blank" href="https://opensupport.alipay.com/support/codelab/detail/766/772">FAST_INSTANT_TRADE_PAY</a>：新快捷即时到账产品。 注：目前仅支持FAST_INSTANT_TRADE_PAY
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 优惠参数  注：仅与支付宝协商后可用
        /// </summary>
        [JsonPropertyName("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// PC扫码支付的方式。 支持前置模式和跳转模式。 前置模式是将二维码前置到商户的订单确认页的模式。需要商户在自己的页面中以 iframe 方式请求支付宝页面。具体支持的枚举值有以下几种： 0：订单码-简约前置模式，对应 iframe 宽度不能小于600px，高度不能小于300px； 1：订单码-前置模式，对应iframe 宽度不能小于 300px，高度不能小于600px； 3：订单码-迷你前置模式，对应 iframe 宽度不能小于 75px，高度不能小于75px； 4：订单码-可定义宽度的嵌入式二维码，商户可根据需要设定二维码的大小。  跳转模式下，用户的扫码界面是由支付宝生成的，不在商户的域名下。支持传入的枚举值有： 2：订单码-跳转模式
        /// </summary>
        [JsonPropertyName("qr_pay_mode")]
        public string QrPayMode { get; set; }

        /// <summary>
        /// 商户自定义二维码宽度。 注：qr_pay_mode=4时该参数有效
        /// </summary>
        [JsonPropertyName("qrcode_width")]
        public long QrcodeWidth { get; set; }

        /// <summary>
        /// 请求来源地址。如果使用ALIAPP的集成方式，用户中途取消支付会返回该地址。
        /// </summary>
        [JsonPropertyName("request_from_url")]
        public string RequestFromUrl { get; set; }

        /// <summary>
        /// 描述分账信息，json格式。
        /// </summary>
        [JsonPropertyName("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 描述结算信息，json格式。
        /// </summary>
        [JsonPropertyName("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 商户门店编号。 指商户创建门店时输入的门店编号。
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 二级商户信息。 直付通模式和机构间连模式下必传，其它场景下不需要传入。
        /// </summary>
        [JsonPropertyName("sub_merchant")]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单绝对超时时间。 格式为yyyy-MM-dd HH:mm。
        /// </summary>
        [JsonPropertyName("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单相对超时时间。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
