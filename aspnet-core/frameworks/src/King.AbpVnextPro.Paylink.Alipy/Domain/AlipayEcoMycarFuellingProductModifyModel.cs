﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarFuellingProductModifyModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarFuellingProductModifyModel : AlipayObject
    {
        /// <summary>
        /// 外部门店编号系统唯一，该值添加后不可修改，与字段shop_id不能同时为空
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 商品信息集合，JSON格式,注意，该参数将覆盖原有已经设置的数据,即如想除去某一商品，去除后重新设置该字段值。
        /// </summary>
        [JsonPropertyName("product")]
        public List<Product> Product { get; set; }

        /// <summary>
        /// 促销信息集合，JSON格式
        /// </summary>
        [JsonPropertyName("sale")]
        public List<Sale> Sale { get; set; }

        /// <summary>
        /// 车主平台内部门店编号，系统唯一,与字段out_shop_id不能同时为空
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
