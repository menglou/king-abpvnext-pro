using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenBpaasContractQueryResponse.
    /// </summary>
    public class AlipayOpenBpaasContractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 签约状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
