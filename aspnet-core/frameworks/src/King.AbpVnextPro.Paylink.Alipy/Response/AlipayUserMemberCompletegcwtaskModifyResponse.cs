using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserMemberCompletegcwtaskModifyResponse.
    /// </summary>
    public class AlipayUserMemberCompletegcwtaskModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// true推进任务成功，false推进任务失败，需要重试
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
