using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMallEventSendResponse.
    /// </summary>
    public class KoubeiMallEventSendResponse : AlipayResponse
    {
        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonPropertyName("event_id")]
        public string EventId { get; set; }
    }
}
