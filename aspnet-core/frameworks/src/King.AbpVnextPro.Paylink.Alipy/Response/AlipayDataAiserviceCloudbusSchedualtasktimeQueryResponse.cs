using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualtasktimeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleTimeResult Result { get; set; }
    }
}
