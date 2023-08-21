using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayTradeBatchRefundResponse.
    /// </summary>
    public class AlipayTradeBatchRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 请求的批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }
    }
}
