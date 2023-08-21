using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// FaceSearchAnonymousUserInfo Data Structure.
    /// </summary>
    public class FaceSearchAnonymousUserInfo : AlipayObject
    {
        /// <summary>
        /// 商户标识
        /// </summary>
        [JsonPropertyName("merchantid")]
        public string Merchantid { get; set; }

        /// <summary>
        /// 商户uid
        /// </summary>
        [JsonPropertyName("merchantuid")]
        public string Merchantuid { get; set; }
    }
}
