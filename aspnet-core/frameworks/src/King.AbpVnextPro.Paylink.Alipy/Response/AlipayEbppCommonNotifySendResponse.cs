using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppCommonNotifySendResponse.
    /// </summary>
    public class AlipayEbppCommonNotifySendResponse : AlipayResponse
    {
        /// <summary>
        /// 通知的执行结果
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
