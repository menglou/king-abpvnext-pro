﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SkuDescInfo Data Structure.
    /// </summary>
    public class SkuDescInfo : AlipayObject
    {
        /// <summary>
        /// 城市行政代码，用于不同城市定价时使用，默认价格使用-1
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 第三方商户定义的外部属性值Id,多个id用英文逗号分隔
        /// </summary>
        [JsonPropertyName("out_pv_id")]
        public string OutPvId { get; set; }

        /// <summary>
        /// 商户库存量单位id.由外部商户生成,保证同一个商品下的id是唯一，只支持数字、字母和下划线
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }
    }
}
