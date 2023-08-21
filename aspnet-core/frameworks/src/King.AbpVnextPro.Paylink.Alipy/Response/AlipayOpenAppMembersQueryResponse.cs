using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppMembersQueryResponse.
    /// </summary>
    public class AlipayOpenAppMembersQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序成员模型
        /// </summary>
        [JsonPropertyName("app_member_info_list")]
        public List<AppMemberInfo> AppMemberInfoList { get; set; }
    }
}
