﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTrainShopModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTrainShopModifyModel : AlipayObject
    {
        /// <summary>
        /// 经营地址信息
        /// </summary>
        [JsonPropertyName("address_info")]
        public ShopAddressInfo AddressInfo { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [JsonPropertyName("applet_appid")]
        public string AppletAppid { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 店铺简介
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 收款账户
        /// </summary>
        [JsonPropertyName("income_account")]
        public string IncomeAccount { get; set; }

        /// <summary>
        /// 店铺所属商家信息
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public ShopMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部店铺id
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonPropertyName("pic")]
        public string Pic { get; set; }

        /// <summary>
        /// 客服电话列表
        /// </summary>
        [JsonPropertyName("service_phone")]
        public List<string> ServicePhone { get; set; }

        /// <summary>
        /// 支付宝店铺id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 来源类型(XIAOBAO：校宝)
        /// </summary>
        [JsonPropertyName("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 店铺url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
