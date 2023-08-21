using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMicropayOrderConfirmpayurlGetResponse.
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetResponse : AlipayResponse
    {
        /// <summary>
        /// SinglePayDetail信息
        /// </summary>
        [JsonPropertyName("single_pay_detail")]
        public SinglePayDetail SinglePayDetail { get; set; }
    }
}
