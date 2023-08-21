﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAccountOrderConsultModel Data Structure.
    /// </summary>
    public class AlipayUserAccountOrderConsultModel : AlipayObject
    {
        /// <summary>
        /// 与场景码相关的扩展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public ConsultParams ExtInfo { get; set; }

        /// <summary>
        /// 集团havana ID
        /// </summary>
        [JsonPropertyName("hid")]
        public string Hid { get; set; }

        /// <summary>
        /// 登录ID
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
