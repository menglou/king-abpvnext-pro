﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentItemCreateModel : AlipayObject
    {
        /// <summary>
        /// 商品条码
        /// </summary>
        [JsonPropertyName("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 商品条码类型
        /// </summary>
        [JsonPropertyName("barcode_type")]
        public string BarcodeType { get; set; }

        /// <summary>
        /// 商品扩展信息；请参见产品文档
        /// </summary>
        [JsonPropertyName("biz_extends")]
        public List<ItemExt> BizExtends { get; set; }

        /// <summary>
        /// 业务唯一ID
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 后台叶子类目ID；平台分配
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品自定义属性
        /// </summary>
        [JsonPropertyName("custom_properties")]
        public List<ItemProperty> CustomProperties { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 商品详情图地址；最多3张
        /// </summary>
        [JsonPropertyName("detail_pic_paths")]
        public List<string> DetailPicPaths { get; set; }

        /// <summary>
        /// 商品详情地址；目前只支持传一个支付宝小程序地址
        /// </summary>
        [JsonPropertyName("detail_urls")]
        public List<ItemUrl> DetailUrls { get; set; }

        /// <summary>
        /// 商品主图地址
        /// </summary>
        [JsonPropertyName("major_pic_path")]
        public string MajorPicPath { get; set; }

        /// <summary>
        /// 商品原价；单位:分
        /// </summary>
        [JsonPropertyName("origin_price")]
        public long OriginPrice { get; set; }

        /// <summary>
        /// 商品售价；单位:分
        /// </summary>
        [JsonPropertyName("sale_price")]
        public long SalePrice { get; set; }

        /// <summary>
        /// 商品状态；可选值：VALID（上架）、INVALID（下架）；传空默认VALID
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 库存状态；可选值：SOLD_OUT（售罄）、AVAILABLE（可售）；非空情况status为INVALID时必须为AVAILABLE；传空情况默认为AVAILABLE
        /// </summary>
        [JsonPropertyName("stock_status")]
        public string StockStatus { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
