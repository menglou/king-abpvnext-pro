using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationQueryResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 充值业务用户与商户的关系
        /// </summary>
        [JsonPropertyName("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
