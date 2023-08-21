using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PintuanUserInfos Data Structure.
    /// </summary>
    public class PintuanUserInfos : AlipayObject
    {
        /// <summary>
        /// 拼团用户信息列表
        /// </summary>
        [JsonPropertyName("pintuan_user_info_list")]
        public PintuanUserInfo PintuanUserInfoList { get; set; }
    }
}
