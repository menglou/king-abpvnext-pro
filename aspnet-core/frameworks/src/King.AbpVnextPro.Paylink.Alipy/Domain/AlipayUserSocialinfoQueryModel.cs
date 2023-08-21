using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserSocialinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayUserSocialinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID，不可为空，最大一次传递10个
        /// </summary>
        [JsonPropertyName("user_id_list")]
        public List<string> UserIdList { get; set; }
    }
}
