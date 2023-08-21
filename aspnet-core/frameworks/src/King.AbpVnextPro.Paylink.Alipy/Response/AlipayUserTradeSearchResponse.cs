using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserTradeSearchResponse.
    /// </summary>
    public class AlipayUserTradeSearchResponse : AlipayResponse
    {
        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_results")]
        public string TotalResults { get; set; }

        /// <summary>
        /// 交易记录列表
        /// </summary>
        [JsonPropertyName("trade_records")]
        public List<TradeRecord> TradeRecords { get; set; }
    }
}
