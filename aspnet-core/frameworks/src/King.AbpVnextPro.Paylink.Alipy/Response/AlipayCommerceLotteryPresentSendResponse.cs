using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceLotteryPresentSendResponse.
    /// </summary>
    public class AlipayCommerceLotteryPresentSendResponse : AlipayResponse
    {
        /// <summary>
        /// 是否赠送成功
        /// </summary>
        [JsonPropertyName("send_result")]
        public bool SendResult { get; set; }
    }
}
