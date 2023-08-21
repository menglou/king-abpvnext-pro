﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayFundTransUniTransferModel Data Structure.
    /// </summary>
    public class AlipayFundTransUniTransferModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，可传的参数如下： DIRECT_TRANSFER：单笔无密转账到支付宝，B2C现金红包; PERSONAL_COLLECTION：C2C现金红包-领红包
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账业务请求的扩展参数，支持传入的扩展参数如下： sub_biz_scene 子业务场景，红包业务必传，取值REDPACKET，C2C现金红包、B2C现金红包均需传入
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 多币种信息字段，填充支付金额及币种，转账金额及币种，结算金额及币种
        /// </summary>
        [JsonPropertyName("mutiple_currency_detail")]
        public MutipleCurrencyDetail MutipleCurrencyDetail { get; set; }

        /// <summary>
        /// 转账业务的标题，用于在支付宝用户的账单里显示
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 原支付宝业务单号。C2C现金红包-红包领取时，传红包支付时返回的支付宝单号；B2C现金红包、单笔无密转账到支付宝不需要该参数。
        /// </summary>
        [JsonPropertyName("original_order_id")]
        public string OriginalOrderId { get; set; }

        /// <summary>
        /// 商家侧唯一订单号，由商家自定义。对于不同转账请求，商家需保证该订单号在自身系统唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [JsonPropertyName("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonPropertyName("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [JsonPropertyName("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码， 单笔无密转账到支付宝账户固定为: TRANS_ACCOUNT_NO_PWD； 收发现金红包固定为: STD_RED_PACKET；
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 签名信息
        /// </summary>
        [JsonPropertyName("sign_data")]
        public SignData SignData { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，STD_RED_PACKET产品取值范围[0.01,100000000]； TRANS_ACCOUNT_NO_PWD产品取值范围[0.1,100000000]
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }
    }
}
