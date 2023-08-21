using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityCreateResponse.
    /// </summary>
    public class AlipayOpenSpBlueseaactivityCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单Id
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
