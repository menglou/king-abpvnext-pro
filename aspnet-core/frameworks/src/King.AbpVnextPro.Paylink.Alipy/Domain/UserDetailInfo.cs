using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// UserDetailInfo Data Structure.
    /// </summary>
    public class UserDetailInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户其他详细信息列表，比如商户或者其他平台的信息。
        /// </summary>
        [JsonPropertyName("ext_profile_list")]
        public List<UserProfileDetail> ExtProfileList { get; set; }
    }
}
