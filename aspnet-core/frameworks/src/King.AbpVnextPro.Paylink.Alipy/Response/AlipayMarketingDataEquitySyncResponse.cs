using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingDataEquitySyncResponse.
    /// </summary>
    public class AlipayMarketingDataEquitySyncResponse : AlipayResponse
    {
        /// <summary>
        /// true/false
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
