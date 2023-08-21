using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMobilePublicContactFollowListResponse.
    /// </summary>
    public class AlipayMobilePublicContactFollowListResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码，如200，标识成功
        /// </summary>
        [JsonPropertyName("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 联系人关注者列表
        /// </summary>
        [JsonPropertyName("contact_follow_list")]
        public List<string> ContactFollowList { get; set; }
    }
}
