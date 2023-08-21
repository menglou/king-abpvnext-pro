using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayWeiboTokenGetResponse.
    /// </summary>
    public class AlipayWeiboTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 访问账单查询的临时令牌
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}
