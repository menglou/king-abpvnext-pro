﻿using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPayCodecApplepayEstablishSetResponse.
    /// </summary>
    public class AlipayPayCodecApplepayEstablishSetResponse : AlipayResponse
    {
        /// <summary>
        /// 结果。 statusCode:Status code used to indicate an error. If omitted, assumed to be 200 (success);subStatusCode:Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions;statusMessage:Not parsed programmatically. Example "Downstream system offline".
        /// </summary>
        [JsonPropertyName("response_header")]
        public EstablishResponseHeader ResponseHeader { get; set; }
    }
}
