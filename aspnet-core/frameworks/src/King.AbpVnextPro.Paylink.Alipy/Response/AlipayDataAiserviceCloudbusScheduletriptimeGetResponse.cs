using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletriptimeGetResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletriptimeGetResponse : AlipayResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("result")]
        public ScheduleTripResult Result { get; set; }
    }
}
