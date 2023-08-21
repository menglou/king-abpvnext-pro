using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusSchedualconfigGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusSchedualconfigGetResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleConfigGetResult Result { get; set; }
    }
}
