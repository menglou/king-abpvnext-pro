﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoMycarMaintainServiceproductUpdateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarMaintainServiceproductUpdateModel : AlipayObject
    {
        /// <summary>
        /// 请求操作（INSERT：新增；MODIFY：修改；DELETE：删除；QUERY：查询）
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 外部服务商品标示，ISV保证唯一性。ISV同一门店同一服务项同一产品名称，只能配置一个商品。（存在同一服务项类目对应多个产品情况，5座普通洗车、5座SUV洗车）
        /// </summary>
        [JsonPropertyName("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 查询删除：否  新增修改：必填
        /// </summary>
        [JsonPropertyName("shop_product")]
        public MaitainShopProduct ShopProduct { get; set; }
    }
}
