using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodQuoteQueryModel Data Structure.
    /// </summary>
    public class AlipayInsAutoAutoinsprodQuoteQueryModel : AlipayObject
    {
        /// <summary>
        /// 询价ID
        /// </summary>
        [JsonPropertyName("enquiry_biz_id")]
        public string EnquiryBizId { get; set; }

        /// <summary>
        /// 报价ID
        /// </summary>
        [JsonPropertyName("quote_biz_id")]
        public string QuoteBizId { get; set; }
    }
}
