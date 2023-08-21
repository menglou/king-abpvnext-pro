using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceIotIntentQueryResponse.
    /// </summary>
    public class AlipayIserviceIotIntentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// iot的响应类
        /// </summary>
        [JsonPropertyName("iot_response")]
        public IntentQueryResponse IotResponse { get; set; }
    }
}
