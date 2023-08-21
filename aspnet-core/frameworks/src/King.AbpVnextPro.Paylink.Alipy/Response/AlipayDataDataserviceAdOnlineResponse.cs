﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOnlineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOnlineResponse : AlipayResponse
    {
        /// <summary>
        /// 操作成功外部ID列表
        /// </summary>
        [JsonPropertyName("success_id_list")]
        public List<string> SuccessIdList { get; set; }
    }
}
