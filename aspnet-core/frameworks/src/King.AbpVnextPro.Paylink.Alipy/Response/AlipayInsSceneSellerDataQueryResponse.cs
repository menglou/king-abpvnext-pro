using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneSellerDataQueryResponse.
    /// </summary>
    public class AlipayInsSceneSellerDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回数据结果
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
