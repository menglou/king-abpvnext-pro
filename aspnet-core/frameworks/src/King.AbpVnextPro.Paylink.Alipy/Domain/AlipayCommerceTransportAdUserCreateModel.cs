﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdUserCreateModel : AlipayObject
    {
        /// <summary>
        /// 广告主用户信息，参见文档
        /// </summary>
        [JsonPropertyName("ad_user")]
        public AdUser AdUser { get; set; }
    }
}
