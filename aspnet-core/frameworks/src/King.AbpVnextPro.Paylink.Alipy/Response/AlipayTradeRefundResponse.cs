﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTradeRefundResponse.
    /// </summary>
    public class AlipayTradeRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 用户的登录id
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 本次退款是否发生了资金变化
        /// </summary>
        [JsonPropertyName("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 退款支付时间
        /// </summary>
        [JsonPropertyName("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 是否有银行卡冲退
        /// </summary>
        [JsonPropertyName("has_deposit_back")]
        public string HasDepositBack { get; set; }

        /// <summary>
        /// 买家支付宝用户号，该参数已废弃，请不要使用
        /// </summary>
        [JsonPropertyName("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额; 该字段默认不返回；
        /// </summary>
        [JsonPropertyName("present_refund_buyer_amount")]
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额； 该字段默认不返回；
        /// </summary>
        [JsonPropertyName("present_refund_discount_amount")]
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额； 该字段默认不返回；
        /// </summary>
        [JsonPropertyName("present_refund_mdiscount_amount")]
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 本次退款针对收款方的退收费金额； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [JsonPropertyName("refund_charge_amount")]
        public string RefundChargeAmount { get; set; }

        /// <summary>
        /// 退款币种信息
        /// </summary>
        [JsonPropertyName("refund_currency")]
        public string RefundCurrency { get; set; }

        /// <summary>
        /// 退款使用的资金渠道。 只有在签约中指定需要返回资金明细，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [JsonPropertyName("refund_detail_item_list")]
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款总金额。 指该笔交易累计已经退款成功的金额。
        /// </summary>
        [JsonPropertyName("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退回的前置资产列表
        /// </summary>
        [JsonPropertyName("refund_preset_paytool_list")]
        public PresetPayToolInfo RefundPresetPaytoolList { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        [JsonPropertyName("refund_settlement_id")]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 本次商户实际退回金额。 说明：如需获取该值，需在入参query_options中传入 refund_detail_item_list。
        /// </summary>
        [JsonPropertyName("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 交易在支付时候的门店名称
        /// </summary>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 2013112011001004330000121536
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
