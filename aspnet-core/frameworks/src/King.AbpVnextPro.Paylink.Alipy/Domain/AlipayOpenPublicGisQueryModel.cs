using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicGisQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicGisQueryModel : AlipayObject
    {
        /// <summary>
        /// 该用户的userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
