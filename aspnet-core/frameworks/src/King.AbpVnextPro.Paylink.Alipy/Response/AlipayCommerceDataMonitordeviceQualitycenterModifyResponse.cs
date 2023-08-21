using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceDataMonitordeviceQualitycenterModifyResponse.
    /// </summary>
    public class AlipayCommerceDataMonitordeviceQualitycenterModifyResponse : AlipayResponse
    {
        /// <summary>
        /// error_detail，出错的情况下返回，包含具体信息。
        /// </summary>
        [JsonPropertyName("error_detail")]
        public string ErrorDetail { get; set; }
    }
}
