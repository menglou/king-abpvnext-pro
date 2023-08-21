using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceBikepriceGetResponse.
    /// </summary>
    public class AlipayDataAiserviceBikepriceGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<CardPriceResponseItem> Result { get; set; }
    }
}
