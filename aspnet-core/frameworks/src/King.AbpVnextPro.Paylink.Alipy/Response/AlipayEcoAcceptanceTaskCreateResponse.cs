using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoAcceptanceTaskCreateResponse.
    /// </summary>
    public class AlipayEcoAcceptanceTaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建的任务ID
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 结果记录条数
        /// </summary>
        [JsonPropertyName("total_results")]
        public long TotalResults { get; set; }
    }
}
