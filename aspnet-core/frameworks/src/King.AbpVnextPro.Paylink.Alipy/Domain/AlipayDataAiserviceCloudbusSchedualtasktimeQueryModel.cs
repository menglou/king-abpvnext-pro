using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtasktimeQueryModel : AlipayObject
    {
        /// <summary>
        /// 接口版本
        /// </summary>
        [JsonPropertyName("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }
    }
}
