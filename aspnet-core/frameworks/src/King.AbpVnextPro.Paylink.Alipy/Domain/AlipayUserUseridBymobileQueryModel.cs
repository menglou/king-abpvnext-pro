﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserUseridBymobileQueryModel Data Structure.
    /// </summary>
    public class AlipayUserUseridBymobileQueryModel : AlipayObject
    {
        /// <summary>
        /// 手机号码，大陆的目前是11位手机号码；海外的是国家码、横杠和号码，如1-123123123
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户类型：1 - 企业类型； 2 - 个人类型。 按照所传内容进行过滤，如果不传则不过滤。
        /// </summary>
        [JsonPropertyName("user_type")]
        public long UserType { get; set; }
    }
}
