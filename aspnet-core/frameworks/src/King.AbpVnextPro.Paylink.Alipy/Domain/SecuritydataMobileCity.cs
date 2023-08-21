﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SecuritydataMobileCity Data Structure.
    /// </summary>
    public class SecuritydataMobileCity : AlipayObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 手机号前七位
        /// </summary>
        [JsonPropertyName("phone_first_7_digits")]
        public string PhoneFirst7Digits { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
