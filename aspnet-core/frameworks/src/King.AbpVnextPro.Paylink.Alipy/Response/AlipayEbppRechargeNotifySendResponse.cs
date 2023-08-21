using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppRechargeNotifySendResponse.
    /// </summary>
    public class AlipayEbppRechargeNotifySendResponse : AlipayResponse
    {
        /// <summary>
        /// 操作状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
