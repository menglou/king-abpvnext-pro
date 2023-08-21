using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiservicePriceoptimizerGetResponse.
    /// </summary>
    public class AlipayDataAiservicePriceoptimizerGetResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐价格返回列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<MakePriceResult> Result { get; set; }
    }
}
