﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOverseasTravelGoodsSyncModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelGoodsSyncModel : AlipayObject
    {
        /// <summary>
        /// 商品首图，外部商品图片地址
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 外链地址，仅支持白名单内的H5& 小程序地址
        /// </summary>
        [JsonPropertyName("external_link_url")]
        public string ExternalLinkUrl { get; set; }

        /// <summary>
        /// 商品分类枚举,请向支付宝业务对口BD询问可用的枚举值。
        /// </summary>
        [JsonPropertyName("goods_category")]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品标签，可空或传入一个或多个
        /// </summary>
        [JsonPropertyName("goods_tags")]
        public List<string> GoodsTags { get; set; }

        /// <summary>
        /// 是否同步库存，是传Y，否则传N，默认不填为N
        /// </summary>
        [JsonPropertyName("inventory_sync")]
        public string InventorySync { get; set; }

        /// <summary>
        /// 商品原价，币种遵循 ISO 4217 标准，金额数值为正整数且精确到货币最小单位
        /// </summary>
        [JsonPropertyName("original_price")]
        public Amount OriginalPrice { get; set; }

        /// <summary>
        /// 外部商户或第三方的商品ID，app_id、out_shop_id、out_goods_id唯一标识一个商品请求。
        /// </summary>
        [JsonPropertyName("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 过期参数，从1.1以后，该参数不再使用。建议使用参数out_shop_ids
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 外部店铺ID列表，对于特定行业可选，比如GOL线上商品的场景非必填。对于线下店铺，该参数必填。 连锁商户，一种商品可以挂接到多个店铺上,该参数支持传输店铺列表。
        /// </summary>
        [JsonPropertyName("out_shop_ids")]
        public List<string> OutShopIds { get; set; }

        /// <summary>
        /// 商品现价，币种遵循 ISO 4217 标准，金额数值为正整数且精确到货币最小单位
        /// </summary>
        [JsonPropertyName("price")]
        public Amount Price { get; set; }

        /// <summary>
        /// 是否推荐，如推荐则平台会优先展示该菜品，是传Y，否则传N，默认不填为N
        /// </summary>
        [JsonPropertyName("recommend")]
        public string Recommend { get; set; }

        /// <summary>
        /// 销售截止时间。标准时间格式：yyyy-MM-dd HH:mm:ss 如果不填代表长期有效，与sale_start_time配合使用
        /// </summary>
        [JsonPropertyName("sale_end_time")]
        public string SaleEndTime { get; set; }

        /// <summary>
        /// 销售开始时间。标准时间格式：yyyy-MM-dd HH:mm:ss 如果不填代表长期有效，与sale_end_time配合使用
        /// </summary>
        [JsonPropertyName("sale_start_time")]
        public string SaleStartTime { get; set; }

        /// <summary>
        /// 外部平台商品销量
        /// </summary>
        [JsonPropertyName("sales_volume")]
        public GoodsSalesVolume SalesVolume { get; set; }

        /// <summary>
        /// 业务场景，可传入一个或多个,该字段用来标识商品的适用业务场景。
        /// </summary>
        [JsonPropertyName("scenarios")]
        public List<string> Scenarios { get; set; }

        /// <summary>
        /// 商品状态，仅支持指定枚举值，NORMAL表示如正在售卖，CLOSED表示下架
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
