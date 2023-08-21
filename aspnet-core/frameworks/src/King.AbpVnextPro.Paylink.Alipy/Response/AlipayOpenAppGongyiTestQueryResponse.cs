﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppGongyiTestQueryResponse.
    /// </summary>
    public class AlipayOpenAppGongyiTestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 日期
        /// </summary>
        [JsonPropertyName("createdate")]
        public string Createdate { get; set; }

        /// <summary>
        /// 测试测试测试测试测试
        /// </summary>
        [JsonPropertyName("shopaddress")]
        public AlipayGongyiAddressTest Shopaddress { get; set; }

        /// <summary>
        /// 商铺信息
        /// </summary>
        [JsonPropertyName("shopinfo")]
        public OuterShopDO Shopinfo { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [JsonPropertyName("shopname")]
        public string Shopname { get; set; }

        /// <summary>
        /// 测试测试测试
        /// </summary>
        [JsonPropertyName("shoprecord")]
        public AlipayGongyiModelTest Shoprecord { get; set; }
    }
}
