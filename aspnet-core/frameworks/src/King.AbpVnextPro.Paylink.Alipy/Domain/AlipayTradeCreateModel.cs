﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayTradeCreateModel Data Structure.
    /// </summary>
    public class AlipayTradeCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝店铺编号。 指商户创建门店后支付宝生成的门店ID。
        /// </summary>
        [JsonPropertyName("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定，应用于安全，营销等参数直传场景，格式为json格式
        /// </summary>
        [JsonPropertyName("business_params")]
        public BusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝用户ID。 2088开头的16位纯数字，小程序场景下获取用户ID请参考：<a target="_blank" href="https://opendocs.alipay.com/mini/introduce/authcode" >用户授权</a>; 其它场景下获取用户ID请参考：<a target="_blank" href="https://opendocs.alipay.com/open/284/106001/#s4" >网页授权获取用户信息</a>; 注：交易的买家与卖家不能相同。
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝登录账号。 buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割  注，与enable_pay_channels互斥  <a href="https://docs.open.alipay.com/common/wifww7">渠道列表</a>
        /// </summary>
        [JsonPropertyName("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 可打折金额。 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        [JsonPropertyName("discountable_amount")]
        public string DiscountableAmount { get; set; }

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
        /// 物流信息
        /// </summary>
        [JsonPropertyName("logistics_detail")]
        public LogisticsDetail LogisticsDetail { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 商户操作员编号。
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

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
        /// 产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： <a target="_blank" href="https://opensupport.alipay.com/support/codelab/detail/486/487">FACE_TO_FACE_PAYMENT</a>：当面付产品； 默认值为FACE_TO_FACE_PAYMENT。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 收货人及地址信息
        /// </summary>
        [JsonPropertyName("receiver_address_info")]
        public ReceiverAddressInfo ReceiverAddressInfo { get; set; }

        /// <summary>
        /// 描述分账信息，json格式。
        /// </summary>
        [JsonPropertyName("royalty_info")]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户>请求传入的seller_id>商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

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
        /// 商户机具终端编号。
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 订单相对超时时间。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 当面付场景默认值为3h；  其它场景默认值为15d;
        /// </summary>
        [JsonPropertyName("timeout_express")]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额。 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】=【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        [JsonPropertyName("undiscountable_amount")]
        public string UndiscountableAmount { get; set; }
    }
}
