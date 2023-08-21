using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// OuterMemberInfo Data Structure.
    /// </summary>
    public class OuterMemberInfo : AlipayObject
    {
        /// <summary>
        /// 商户记录的用户信息
        /// </summary>
        [JsonPropertyName("user_info")]
        public string UserInfo { get; set; }
    }
}
