using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataServiceOpenAnalyzeResponse.
    /// </summary>
    public class AlipayDataServiceOpenAnalyzeResponse : AlipayResponse
    {
        /// <summary>
        /// 调用返回
        /// </summary>
        [JsonPropertyName("result")]
        public AlipayDataServiceResult Result { get; set; }
    }
}
