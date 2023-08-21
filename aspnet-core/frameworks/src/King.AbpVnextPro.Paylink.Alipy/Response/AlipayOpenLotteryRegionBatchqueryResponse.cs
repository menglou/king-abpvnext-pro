using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionBatchqueryResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商家入驻专区列表
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
