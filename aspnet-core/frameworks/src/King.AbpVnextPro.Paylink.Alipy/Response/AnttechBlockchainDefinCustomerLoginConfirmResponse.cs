using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerLoginConfirmResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerLoginConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("user_info")]
        public DefiCustUserDTO UserInfo { get; set; }
    }
}
