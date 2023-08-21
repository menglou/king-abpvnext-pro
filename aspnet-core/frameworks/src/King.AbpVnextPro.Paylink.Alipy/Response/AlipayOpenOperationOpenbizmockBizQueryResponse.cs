using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockBizQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
