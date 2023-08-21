using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AnttechBlockchainDefinDataserviceVerifySubmitResponse.
    /// </summary>
    public class AnttechBlockchainDefinDataserviceVerifySubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }
    }
}
