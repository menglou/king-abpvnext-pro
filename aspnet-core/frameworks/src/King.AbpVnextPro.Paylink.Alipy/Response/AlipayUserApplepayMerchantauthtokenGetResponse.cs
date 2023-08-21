﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserApplepayMerchantauthtokenGetResponse.
    /// </summary>
    public class AlipayUserApplepayMerchantauthtokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 商户授权token
        /// </summary>
        [JsonPropertyName("merchant_auth_token")]
        public string MerchantAuthToken { get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [JsonPropertyName("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
