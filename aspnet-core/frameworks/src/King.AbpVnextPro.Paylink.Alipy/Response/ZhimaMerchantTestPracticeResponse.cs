using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaMerchantTestPracticeResponse.
    /// </summary>
    public class ZhimaMerchantTestPracticeResponse : AlipayResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [JsonPropertyName("dddd")]
        public XXXXsdasdasd Dddd { get; set; }

        /// <summary>
        /// ccc
        /// </summary>
        [JsonPropertyName("sss")]
        public string Sss { get; set; }
    }
}
