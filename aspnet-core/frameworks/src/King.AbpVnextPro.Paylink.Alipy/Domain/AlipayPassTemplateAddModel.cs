﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPassTemplateAddModel Data Structure.
    /// </summary>
    public class AlipayPassTemplateAddModel : AlipayObject
    {
        /// <summary>
        /// 模板内容信息，遵循JSON规范，详情参见tpl_content <a href="https://opendocs.alipay.com/open/016d5g">参数详细说明</a>。
        /// </summary>
        [JsonPropertyName("tpl_content")]
        public string TplContent { get; set; }

        /// <summary>
        /// 商户用于控制模版的唯一性。（可以使用时间戳保证唯一性）
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
