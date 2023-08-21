using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMsaasItapDataSyncResponse.
    /// </summary>
    public class AlipayMsaasItapDataSyncResponse : AlipayResponse
    {
        /// <summary>
        /// Itap统一反回结果模型
        /// </summary>
        [JsonPropertyName("payload")]
        public List<ItapResponsePayload> Payload { get; set; }

        /// <summary>
        /// 请求唯一ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
