﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemSecurityCreateModel : AlipayObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品所属前台类目ID列表
        /// </summary>
        [JsonPropertyName("front_category_id_list")]
        public List<string> FrontCategoryIdList { get; set; }

        /// <summary>
        /// 素材列表（最多3个）
        /// </summary>
        [JsonPropertyName("material_list")]
        public List<MaterialCreateInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        [JsonPropertyName("property_list")]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// 场景码（具体值请参见产品文档）
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 商品SKU列表（至少1个，最多20个）
        /// </summary>
        [JsonPropertyName("sku_list")]
        public List<SkuCreateInfo> SkuList { get; set; }

        /// <summary>
        /// 商品归属主体ID  例：商品归属主体类型为店铺，则商品归属主体ID为店铺ID；
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 商品归属主体类型:  5（店铺）
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }

        /// <summary>
        /// 商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
