﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoCreateModel Data Structure.
    /// </summary>
    public class KoubeiItemExtitemInfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 品牌信息（目前支持3级品牌），填写子级别时，父级别必须已经存在
        /// </summary>
        [JsonPropertyName("brand_level_info_list")]
        public List<BrandLevelInfo> BrandLevelInfoList { get; set; }

        /// <summary>
        /// 商品简述：对商品的简要说明，吸引顾客的描述（非必填）
        /// </summary>
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 品类列表信息（目前支持5级品类），填写子级别时，父级别必须已经存在
        /// </summary>
        [JsonPropertyName("category_level_info_list")]
        public List<CategoryLevelInfo> CategoryLevelInfoList { get; set; }

        /// <summary>
        /// 入数，必须为整数
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 币种，采用ISO 4217 Currency Codes编码，表示该商品售价对应的货币种类：CNY/USD 等
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 商品描述，详细介绍该商品的用途，补充说明等信息
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonPropertyName("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 店内货号：商户店铺内自行对商品的编码
        /// </summary>
        [JsonPropertyName("inner_goods_id")]
        public string InnerGoodsId { get; set; }

        /// <summary>
        /// 商品规格:900ml/500克/12瓶装
        /// </summary>
        [JsonPropertyName("item_format")]
        public string ItemFormat { get; set; }

        /// <summary>
        /// 标记位，如果为true,则创建的商品信息存在时，执行更新操作；如果为false,商品信息存在则直接返回  商品信息已存在 的提示；默认为false
        /// </summary>
        [JsonPropertyName("need_modify")]
        public bool NeedModify { get; set; }

        /// <summary>
        /// 包装：描述该商品的包装形式：盒装/瓶装/袋装/散装
        /// </summary>
        [JsonPropertyName("pack")]
        public string Pack { get; set; }

        /// <summary>
        /// 商品图片file_id列表（最多30张）
        /// </summary>
        [JsonPropertyName("picture_id_list")]
        public List<string> PictureIdList { get; set; }

        /// <summary>
        /// 参考价格，单位（分），必须为整数
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 表示该商品的售卖单位，对单价的补充说明个/箱/盒/克/公斤 等
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }
    }
}
