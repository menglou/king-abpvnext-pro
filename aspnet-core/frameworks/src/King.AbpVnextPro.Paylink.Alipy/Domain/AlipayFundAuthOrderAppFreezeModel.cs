﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayFundAuthOrderAppFreezeModel Data Structure.
    /// </summary>
    public class AlipayFundAuthOrderAppFreezeModel : AlipayObject
    {
        /// <summary>
        /// 需要冻结的金额，单位为：元（人民币），精确到小数点后两位  取值范围：[0.01,100000000.00]
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 商户可用该参数指定禁止使用的支付渠道，本期支持两种禁用渠道：信用卡快捷（OPTIMIZED_MOTO）、信用卡卡通（BIGAMOUNT_CREDIT_CARTOON）。商户可设置一种支付渠道，也可设置多种支付渠道。与可用支付渠道不能同时传入
        /// </summary>
        [JsonPropertyName("disable_pay_channels")]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 商户可用该参数指定用户可使用的支付渠道，本期支持商户可支持三种支付渠道，余额宝（MONEY_FUND）、花呗（PCREDIT_PAY）以及芝麻信用（CREDITZHIMA）。商户可设置一种支付渠道，也可设置多种支付渠道。与禁用支付渠道不可同时传入
        /// </summary>
        [JsonPropertyName("enable_pay_channels")]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递，json格式。 1.授权业务对应的类目，key为category，value由支付宝分配，比如充电桩业务传 "CHARGE_PILE_CAR"若使用信用预授权，则该值必传； 2. 外部商户的门店编号，key为outStoreCode，可选； 3. 外部商户的门店简称，key为outStoreAlias，可选; 4. 外部商户的门店简称，key为outStoreAlias，可选; 5.间联模式必须传入二级商户所属机构id，key为requestOrgId；6.信用服务Id，key为serviceId，信用场景下必传，具体值需要联系芝麻客服https://cshall.alipay.com/enterprise/index.htm?sourceId=pc_zhima（右上角“有问题点我”进入咨询）。
        /// </summary>
        [JsonPropertyName("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 用户实名信息参数，包含：姓名+身份证号的hash值、指定用户的uid。商户传入用户实名信息参数，支付宝会对比用户在支付宝端的实名信息。 姓名+身份证号hash值使用SHA256摘要方式与UTF8编码,返回十六进制的字符串。 identity_hash和alipay_user_id都是可选的，如果两个都传，则会先校验identity_hash，然后校验alipay_user_id。其中identity_hash的待加密字样如"张三4566498798498498498498"
        /// </summary>
        [JsonPropertyName("identity_params")]
        public string IdentityParams { get; set; }

        /// <summary>
        /// 业务订单的简单描述，如商品名称等
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户授权资金订单号，商家自定义需保证在商户端不重复。不能包含除中文、英文、数字以外的字符，创建后不能修改。
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号，用于标示请求流水的唯一性，商家自定义需保证在商户端不重复。不能包含除中文、英文、数字以外的字符。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭该笔订单  取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m  如果为空，默认15m
        /// </summary>
        [JsonPropertyName("pay_timeout")]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 收款方支付宝账号（Email或手机号），如果收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)同时传递，则以用户号(payee_user_id)为准，如果商户有勾选花呗渠道，收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)不能同时为空。
        /// </summary>
        [JsonPropertyName("payee_logon_id")]
        public string PayeeLogonId { get; set; }

        /// <summary>
        /// 收款方的支付宝唯一用户号,以2088开头的16位纯数字组成，如果非空则会在支付时校验交易的的收款方与此是否一致，如果商户有勾选花呗渠道，收款方支付宝登录号(payee_logon_id)和用户号(payee_user_id)不能同时为空。
        /// </summary>
        [JsonPropertyName("payee_user_id")]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 销售产品码。新接入线上预授权的业务，支付宝预授权产品固定为 PRE_AUTH_ONLINE；境外预授权产品固定为 OVERSEAS_INSTORE_AUTH 。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，用于区分预授权不同业务场景。如：当面预授权通用场景（O2O_AUTH_COMMON_SCENE）、支付宝预授权通用场景（ONLINE_AUTH_COMMON_SCENE）、境外当面预授权通用场景（OVERSEAS_O2O_AUTH_COMMON_SCENE）、境外支付预授权通用场景（OVERSEAS_ONLINE_AUTH_COMMON_SCENE）等
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商户指定的结算币种。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        [JsonPropertyName("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP, 人民币：CNY
        /// </summary>
        [JsonPropertyName("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
