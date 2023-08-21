using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPayAppCarPayResponse.
    /// </summary>
    public class AlipayPayAppCarPayResponse : AlipayResponse
    {
        /// <summary>
        /// 上下文token
        /// </summary>
        [JsonPropertyName("context_token")]
        public string ContextToken { get; set; }
    }
}
