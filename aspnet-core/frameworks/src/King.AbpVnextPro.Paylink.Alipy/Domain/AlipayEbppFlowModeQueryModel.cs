using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppFlowModeQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppFlowModeQueryModel : AlipayObject
    {
        /// <summary>
        /// json扩展字段
        /// </summary>
        [JsonPropertyName("ext_msg")]
        public string ExtMsg { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
