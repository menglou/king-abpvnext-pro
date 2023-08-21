using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorUploadResponse.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 成功返回true,失败返回false
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }
    }
}
