using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppServiceApplyResponse.
    /// </summary>
    public class AlipayOpenAppServiceApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
