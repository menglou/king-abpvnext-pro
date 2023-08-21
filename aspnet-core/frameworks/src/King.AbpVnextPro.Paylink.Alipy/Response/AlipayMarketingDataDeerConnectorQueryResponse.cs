using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingDataDeerConnectorQueryResponse.
    /// </summary>
    public class AlipayMarketingDataDeerConnectorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回活动的流量数据
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 请求业务处理是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
