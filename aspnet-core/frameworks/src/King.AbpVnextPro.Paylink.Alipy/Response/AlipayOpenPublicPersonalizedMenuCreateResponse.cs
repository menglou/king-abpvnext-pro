using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedMenuCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedMenuCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 该套个性化菜单key
        /// </summary>
        [JsonPropertyName("menu_key")]
        public string MenuKey { get; set; }
    }
}
