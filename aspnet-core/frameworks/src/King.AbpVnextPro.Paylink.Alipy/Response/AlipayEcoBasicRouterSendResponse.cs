using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoBasicRouterSendResponse.
    /// </summary>
    public class AlipayEcoBasicRouterSendResponse : AlipayResponse
    {
        /// <summary>
        /// 路由返回的数据
        /// </summary>
        [JsonPropertyName("res")]
        public string Res { get; set; }
    }
}
