using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionCreateResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
