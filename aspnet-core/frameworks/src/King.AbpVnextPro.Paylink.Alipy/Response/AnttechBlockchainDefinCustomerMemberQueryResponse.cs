using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainDefinCustomerMemberQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinCustomerMemberQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 会员对象
        /// </summary>
        [JsonPropertyName("member_info_list")]
        public List<DefiCustMemberDTO> MemberInfoList { get; set; }
    }
}
