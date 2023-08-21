using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampresultQueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中奖结果名单
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
