using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusOdGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusOdGetResponse : AlipayResponse
    {
        /// <summary>
        /// od结果
        /// </summary>
        [JsonPropertyName("result")]
        public List<CloudBusOdItem> Result { get; set; }
    }
}
