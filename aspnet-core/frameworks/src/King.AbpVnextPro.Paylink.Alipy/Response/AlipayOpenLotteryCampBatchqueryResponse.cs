using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampBatchqueryResponse.
    /// </summary>
    public class AlipayOpenLotteryCampBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动搜索列表
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
