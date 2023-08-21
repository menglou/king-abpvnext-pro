﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityDataDatabusSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityDataDatabusSendModel : AlipayObject
    {
        /// <summary>
        /// 安全累计属性列表字段，安全属性列表，key为属性名称，value为属性值；如 key:"145" ，value:"1"
        /// </summary>
        [JsonPropertyName("security_content")]
        public string SecurityContent { get; set; }

        /// <summary>
        /// 代码发送给安全核心的事件编码
        /// </summary>
        [JsonPropertyName("security_sign")]
        public string SecuritySign { get; set; }
    }
}
