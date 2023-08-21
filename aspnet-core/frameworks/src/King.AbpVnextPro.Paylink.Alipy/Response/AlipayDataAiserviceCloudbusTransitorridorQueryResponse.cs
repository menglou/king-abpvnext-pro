using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTransitorridorQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTransitorridorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusTransitResultItem Result { get; set; }
    }
}
