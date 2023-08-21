﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ReceiptBizData Data Structure.
    /// </summary>
    public class ReceiptBizData : AlipayObject
    {
        /// <summary>
        /// 交易实付金额，单位分
        /// </summary>
        [JsonPropertyName("actual_pay_amount")]
        public long ActualPayAmount { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonPropertyName("actual_pay_time")]
        public string ActualPayTime { get; set; }

        /// <summary>
        /// 机具身份id
        /// </summary>
        [JsonPropertyName("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 币种（CNY-人命币）
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 取餐号
        /// </summary>
        [JsonPropertyName("fetch_num")]
        public string FetchNum { get; set; }

        /// <summary>
        /// 电子发票链接
        /// </summary>
        [JsonPropertyName("invoice_entry")]
        public string InvoiceEntry { get; set; }

        /// <summary>
        /// 门店优惠金额，单位分
        /// </summary>
        [JsonPropertyName("merchant_discount_amount")]
        public long MerchantDiscountAmount { get; set; }

        /// <summary>
        /// 商户名字
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 订单原价，单位分
        /// </summary>
        [JsonPropertyName("origin_amount")]
        public long OriginAmount { get; set; }

        /// <summary>
        /// 其他优惠
        /// </summary>
        [JsonPropertyName("other_discount_info")]
        public List<ReceiptDiscountInfo> OtherDiscountInfo { get; set; }

        /// <summary>
        /// 外部订单编号,小票编号
        /// </summary>
        [JsonPropertyName("out_trade_id")]
        public string OutTradeId { get; set; }

        /// <summary>
        /// 平台（tmall）优惠金额，单位分
        /// </summary>
        [JsonPropertyName("platform_discount_amount")]
        public long PlatformDiscountAmount { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [JsonPropertyName("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [JsonPropertyName("shop_contract")]
        public string ShopContract { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 商户类型
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        [JsonPropertyName("skus")]
        public List<ReceiptSku> Skus { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 交易来源，barcode-扫码，face-刷脸，other-其他
        /// </summary>
        [JsonPropertyName("trade_source")]
        public string TradeSource { get; set; }
    }
}
