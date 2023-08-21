using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 库存查询结果
        /// </summary>
        [JsonPropertyName("stock_task_result")]
        public StockTaskResult StockTaskResult { get; set; }
    }
}
