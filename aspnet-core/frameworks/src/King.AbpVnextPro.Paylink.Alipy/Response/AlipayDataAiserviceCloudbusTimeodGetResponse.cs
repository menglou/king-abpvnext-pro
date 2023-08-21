using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusTimeodGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusTimeodGetResponse : AlipayResponse
    {
        /// <summary>
        /// od分时结果列表
        /// </summary>
        [JsonPropertyName("result")]
        public List<CloudbusTimeOdItem> Result { get; set; }
    }
}
