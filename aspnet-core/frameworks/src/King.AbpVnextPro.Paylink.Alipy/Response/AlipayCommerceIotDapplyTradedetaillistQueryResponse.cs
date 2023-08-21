using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyTradedetaillistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyTradedetaillistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易明细
        /// </summary>
        [JsonPropertyName("devicetradedetaillist")]
        public List<DeviceTradeDetail> Devicetradedetaillist { get; set; }

        /// <summary>
        /// 表示记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
