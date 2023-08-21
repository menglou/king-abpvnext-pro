using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceEducateSignTokenQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateSignTokenQueryModel : AlipayObject
    {
        /// <summary>
        /// 加密TOKEN
        /// </summary>
        [JsonPropertyName("token_key")]
        public string TokenKey { get; set; }
    }
}
