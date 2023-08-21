using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerSmilepayInitializeResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerSmilepayInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 返回值
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
