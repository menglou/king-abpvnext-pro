using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppServiceModifyResponse.
    /// </summary>
    public class AlipayOpenAppServiceModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
