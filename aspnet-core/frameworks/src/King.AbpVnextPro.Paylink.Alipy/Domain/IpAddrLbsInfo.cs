﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// IpAddrLbsInfo Data Structure.
    /// </summary>
    public class IpAddrLbsInfo : AlipayObject
    {
        /// <summary>
        /// IP地址归属地所以城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// IP归属地所在的省
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
