using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherSendResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherSendResponse : AlipayResponse
    {
        /// <summary>
        /// 本次发放的券码
        /// </summary>
        [JsonPropertyName("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
