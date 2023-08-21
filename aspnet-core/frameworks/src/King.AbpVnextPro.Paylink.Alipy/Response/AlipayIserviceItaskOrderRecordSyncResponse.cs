using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceItaskOrderRecordSyncResponse.
    /// </summary>
    public class AlipayIserviceItaskOrderRecordSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("home_api_response")]
        public HomeApiResponse HomeApiResponse { get; set; }
    }
}
