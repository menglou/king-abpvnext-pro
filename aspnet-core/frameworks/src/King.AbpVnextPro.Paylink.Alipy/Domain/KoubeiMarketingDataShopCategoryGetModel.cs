﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingDataShopCategoryGetModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataShopCategoryGetModel : AlipayObject
    {
        /// <summary>
        /// 该参数标识需要返回几个分类，多余的分类将会放于other字段中，最大值传入50，默认值10
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 商圈ID
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }
    }
}
