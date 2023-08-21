using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySecurityProdEdgeColorQueryResponse.
    /// </summary>
    public class AlipaySecurityProdEdgeColorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务端解析后的风险等级信息
        /// </summary>
        [JsonPropertyName("risk_result")]
        public string RiskResult { get; set; }
    }
}
