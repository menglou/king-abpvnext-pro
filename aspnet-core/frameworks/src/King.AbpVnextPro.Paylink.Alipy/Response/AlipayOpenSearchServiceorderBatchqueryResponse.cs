using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenSearchServiceorderBatchqueryResponse.
    /// </summary>
    public class AlipayOpenSearchServiceorderBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单列表
        /// </summary>
        [JsonPropertyName("data")]
        public OrderPageQueryDTO Data { get; set; }
    }
}
