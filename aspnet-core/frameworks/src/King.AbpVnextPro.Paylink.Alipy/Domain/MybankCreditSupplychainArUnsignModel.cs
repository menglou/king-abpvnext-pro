﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MybankCreditSupplychainArUnsignModel Data Structure.
    /// </summary>
    public class MybankCreditSupplychainArUnsignModel : AlipayObject
    {
        /// <summary>
        /// 协议产品码
        /// </summary>
        [JsonPropertyName("ar_pd_code")]
        public string ArPdCode { get; set; }

        /// <summary>
        /// 请求幂等控制ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("seller_ar_no")]
        public string SellerArNo { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 站点，目前只支持ALIPAY
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 场景来源
        /// </summary>
        [JsonPropertyName("trade_source")]
        public string TradeSource { get; set; }
    }
}
