using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionGetResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionGetResponse : AlipayResponse
    {
        /// <summary>
        /// 入驻商家专区信息
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
