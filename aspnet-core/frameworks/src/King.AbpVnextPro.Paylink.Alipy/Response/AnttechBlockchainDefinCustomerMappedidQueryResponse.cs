using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMappedidQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMappedidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员信息
        /// </summary>
        [JsonPropertyName("user_info_list")]
        public List<DefiCustUserDTO> UserInfoList { get; set; }
    }
}
