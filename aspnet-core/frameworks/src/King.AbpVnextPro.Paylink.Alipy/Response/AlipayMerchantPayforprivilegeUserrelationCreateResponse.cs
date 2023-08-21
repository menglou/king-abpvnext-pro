using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeUserrelationCreateResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeUserrelationCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 充值业务用户与商户关系
        /// </summary>
        [JsonPropertyName("member_info")]
        public PayForPrivilegeUserRelation MemberInfo { get; set; }
    }
}
