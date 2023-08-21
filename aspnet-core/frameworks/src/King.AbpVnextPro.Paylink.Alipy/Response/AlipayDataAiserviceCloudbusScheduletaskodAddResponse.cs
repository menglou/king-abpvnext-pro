using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodAddResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodAddResponse : AlipayResponse
    {
        /// <summary>
        /// 任务结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
