using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiShopWxloginQueryResponse.
    /// </summary>
    public class KoubeiShopWxloginQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户唯一标识的 openid
        /// </summary>
        [JsonPropertyName("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 会话密钥
        /// </summary>
        [JsonPropertyName("session_key")]
        public string SessionKey { get; set; }
    }
}
