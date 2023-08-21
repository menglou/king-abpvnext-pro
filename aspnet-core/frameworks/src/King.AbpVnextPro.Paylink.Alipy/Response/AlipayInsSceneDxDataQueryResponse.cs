using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneDxDataQueryResponse.
    /// </summary>
    public class AlipayInsSceneDxDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回dx数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
