using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockOpenidnonstandQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenbizmockOpenidnonstandQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模拟结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
