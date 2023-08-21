using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundTransAacollectBatchCloseResponse.
    /// </summary>
    public class AlipayFundTransAacollectBatchCloseResponse : AlipayResponse
    {
        /// <summary>
        /// * 批次状态       * <p>       *      <b>一阶段模式:</b>       *      <pre>       *                                 ----> SUCCESS       *                              /       *                             /       *          INIT ----------> FIRST_STAGE---> PART_SUCCESS       *                             \       *                              \       *                               -----> FAIL       *      </pre>       * </p>
        /// </summary>
        [JsonPropertyName("batch_status")]
        public string BatchStatus { get; set; }
    }
}
