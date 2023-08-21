﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ShopDiscountInfo Data Structure.
    /// </summary>
    public class ShopDiscountInfo : AlipayObject
    {
        /// <summary>
        /// 图片url
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 优惠信息描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否全场。  全场：Y，单品：N
        /// </summary>
        [JsonPropertyName("is_all")]
        public string IsAll { get; set; }

        /// <summary>
        /// 支付宝商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 子类型
        /// </summary>
        [JsonPropertyName("promo_sub_type")]
        public string PromoSubType { get; set; }

        /// <summary>
        /// 优惠类型。  优惠：discount  商品：item
        /// </summary>
        [JsonPropertyName("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 领用模式。自动领用：AUTO_OBTAIN。手动领用：OBTAIN
        /// </summary>
        [JsonPropertyName("purchase_mode")]
        public string PurchaseMode { get; set; }

        /// <summary>
        /// 已用数量
        /// </summary>
        [JsonPropertyName("sales_quantity")]
        public string SalesQuantity { get; set; }

        /// <summary>
        /// 优惠信息标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }
    }
}
