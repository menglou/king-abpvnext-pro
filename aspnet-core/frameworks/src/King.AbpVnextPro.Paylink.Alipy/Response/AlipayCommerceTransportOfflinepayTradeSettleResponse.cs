using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportOfflinepayTradeSettleResponse.
    /// </summary>
    public class AlipayCommerceTransportOfflinepayTradeSettleResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝脱机交易处理结果列表
        /// </summary>
        [JsonPropertyName("result_list")]
        public List<AlipayOfflineTradeResult> ResultList { get; set; }
    }
}
