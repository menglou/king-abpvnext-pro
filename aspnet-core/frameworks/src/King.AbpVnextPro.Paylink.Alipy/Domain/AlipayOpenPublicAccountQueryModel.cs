using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicAccountQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户的支付宝用户号，2088开头。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
