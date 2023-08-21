using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoPrinterStatusQueryResponse.
    /// </summary>
    public class AlipayEcoPrinterStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 0离线 1在线 2缺纸
        /// </summary>
        [JsonPropertyName("state")]
        public long State { get; set; }
    }
}
