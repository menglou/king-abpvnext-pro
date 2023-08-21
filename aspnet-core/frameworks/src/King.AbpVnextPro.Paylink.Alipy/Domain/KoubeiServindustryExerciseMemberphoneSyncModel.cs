using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberphoneSyncModel Data Structure.
    /// </summary>
    public class KoubeiServindustryExerciseMemberphoneSyncModel : AlipayObject
    {
        /// <summary>
        /// 存量健身会员手机号
        /// </summary>
        [JsonPropertyName("phone_list")]
        public List<string> PhoneList { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
