using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserApplepayProvisioningbundleModifyResponse.
    /// </summary>
    public class AlipayUserApplepayProvisioningbundleModifyResponse : AlipayResponse
    {
        /// <summary>
        /// ApplePay公用响应头
        /// </summary>
        [JsonPropertyName("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }
    }
}
