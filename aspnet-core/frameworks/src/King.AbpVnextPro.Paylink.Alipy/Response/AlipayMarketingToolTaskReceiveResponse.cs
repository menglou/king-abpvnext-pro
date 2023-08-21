using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolTaskReceiveResponse.
    /// </summary>
    public class AlipayMarketingToolTaskReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 阶段码。applet_signup任务报名。
        /// </summary>
        [JsonPropertyName("stage_code")]
        public string StageCode { get; set; }

        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
