using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerUserQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [JsonPropertyName("user_info_list")]
        public List<DefiCustUserDTO> UserInfoList { get; set; }
    }
}
