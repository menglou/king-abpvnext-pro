using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAraterRatestatusModifyResponse.
    /// </summary>
    public class AlipayOpenAppAraterRatestatusModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 是否更惨成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
