using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserBillDetailQueryResponse.
    /// </summary>
    public class AlipayUserBillDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 消费记录模型
        /// </summary>
        [JsonPropertyName("consume_record")]
        public ConsumeRecord ConsumeRecord { get; set; }
    }
}
