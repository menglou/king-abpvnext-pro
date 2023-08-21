using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdUserMatchModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdUserMatchModel : AlipayObject
    {
        /// <summary>
        /// 第三方平台用户ID
        /// </summary>
        [JsonPropertyName("third_user_id")]
        public string ThirdUserId { get; set; }
    }
}
