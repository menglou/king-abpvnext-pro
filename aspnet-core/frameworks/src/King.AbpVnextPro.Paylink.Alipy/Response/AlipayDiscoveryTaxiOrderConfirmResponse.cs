using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDiscoveryTaxiOrderConfirmResponse.
    /// </summary>
    public class AlipayDiscoveryTaxiOrderConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
