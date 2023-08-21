using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncGfacceptanceBillReverseResponse.
    /// </summary>
    public class AlipayBossFncGfacceptanceBillReverseResponse : AlipayResponse
    {
        /// <summary>
        /// 业财受理结果
        /// </summary>
        [JsonPropertyName("result")]
        public GFAOpenAPIAcceptanceResult Result { get; set; }
    }
}
