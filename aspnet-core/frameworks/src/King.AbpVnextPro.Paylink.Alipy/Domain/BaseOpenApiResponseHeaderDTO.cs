using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BaseOpenApiResponseHeaderDTO Data Structure.
    /// </summary>
    public class BaseOpenApiResponseHeaderDTO : AlipayObject
    {
        /// <summary>
        /// http状态码
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }
    }
}
