using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoAcceptanceRequestCreateResponse.
    /// </summary>
    public class AlipayEcoAcceptanceRequestCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 提交数据ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public long RequestId { get; set; }

        /// <summary>
        /// 结果记录条数
        /// </summary>
        [JsonPropertyName("total_results")]
        public long TotalResults { get; set; }
    }
}
