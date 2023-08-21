using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoTextDetectResponse.
    /// </summary>
    public class AlipayEcoTextDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 检测结果
        /// </summary>
        [JsonPropertyName("data")]
        public List<SpiDetectionDetail> Data { get; set; }
    }
}
