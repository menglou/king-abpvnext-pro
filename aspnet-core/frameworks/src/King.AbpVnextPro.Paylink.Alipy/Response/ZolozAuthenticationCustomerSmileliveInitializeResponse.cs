using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmileliveInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerSmileliveInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// result
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
