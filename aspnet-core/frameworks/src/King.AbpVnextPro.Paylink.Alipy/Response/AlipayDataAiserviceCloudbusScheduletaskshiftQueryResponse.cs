using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskshiftQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleShiftResult Result { get; set; }
    }
}
