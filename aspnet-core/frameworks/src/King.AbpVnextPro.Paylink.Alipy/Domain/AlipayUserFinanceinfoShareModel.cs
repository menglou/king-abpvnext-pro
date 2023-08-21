using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserFinanceinfoShareModel Data Structure.
    /// </summary>
    public class AlipayUserFinanceinfoShareModel : AlipayObject
    {
        /// <summary>
        /// 支付宝会员的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
