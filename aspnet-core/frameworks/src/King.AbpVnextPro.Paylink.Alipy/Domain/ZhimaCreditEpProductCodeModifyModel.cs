﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditEpProductCodeModifyModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpProductCodeModifyModel : AlipayObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [JsonPropertyName("code_id")]
        public string CodeId { get; set; }
    }
}
