using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdUserCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAdUserCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 商家id
        /// </summary>
        [JsonPropertyName("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 账户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
    }
}
