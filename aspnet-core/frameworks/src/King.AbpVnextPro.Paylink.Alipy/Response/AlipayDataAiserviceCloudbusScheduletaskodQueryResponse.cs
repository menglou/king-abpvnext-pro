using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleOdResult Result { get; set; }
    }
}
