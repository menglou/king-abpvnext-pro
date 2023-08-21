﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoSignflowsDetailQueryResponse.
    /// </summary>
    public class AlipayEcoSignflowsDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 创建流程时平台上传的附件及签署时用户上传的附件或身份证
        /// </summary>
        [JsonPropertyName("attachments")]
        public AttachmentDetail Attachments { get; set; }

        /// <summary>
        /// 已签署完成文件列表
        /// </summary>
        [JsonPropertyName("docs")]
        public DocInfo Docs { get; set; }
    }
}
