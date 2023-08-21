﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiItemExtitemUpdateModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemUpdateModel : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonPropertyName("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 入数，必须为整数
        /// </summary>
        [JsonPropertyName("count")]
        public string Count { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商品条码
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品图片file id
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 参考价格，单位（分），必须为整数
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
