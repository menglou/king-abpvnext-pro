﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicTemplateMessageGetResponse.
    /// </summary>
    public class AlipayMobilePublicTemplateMessageGetResponse : AlipayResponse
    {
        /// <summary>
        /// 消息模板id--商户领取母版后生成的唯一模板id
        /// </summary>
        [JsonPropertyName("msg_template_id")]
        public string MsgTemplateId { get; set; }

        /// <summary>
        /// 模板内容
        /// </summary>
        [JsonPropertyName("template")]
        public string Template { get; set; }
    }
}
