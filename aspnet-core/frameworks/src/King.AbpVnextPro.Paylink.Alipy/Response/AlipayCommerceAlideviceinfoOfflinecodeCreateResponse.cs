using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceAlideviceinfoOfflinecodeCreateResponse.
    /// </summary>
    public class AlipayCommerceAlideviceinfoOfflinecodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 机具统一ID
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 离线支付token
        /// </summary>
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
