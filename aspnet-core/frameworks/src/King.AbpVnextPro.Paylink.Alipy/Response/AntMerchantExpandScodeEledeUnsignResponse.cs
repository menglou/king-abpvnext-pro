﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntMerchantExpandScodeEledeUnsignResponse.
    /// </summary>
    public class AntMerchantExpandScodeEledeUnsignResponse : AlipayResponse
    {
        /// <summary>
        /// 去标返回结果
        /// </summary>
        [JsonPropertyName("remove_tag_response")]
        public RemoveTagResponse RemoveTagResponse { get; set; }
    }
}
