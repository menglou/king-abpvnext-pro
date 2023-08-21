using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingVoucherAuthSendResponse.
    /// </summary>
    public class AlipayMarketingVoucherAuthSendResponse : AlipayResponse
    {
        /// <summary>
        /// 券ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
