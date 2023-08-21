using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppDfsfasDeQueryResponse.
    /// </summary>
    public class AlipayOpenAppDfsfasDeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
