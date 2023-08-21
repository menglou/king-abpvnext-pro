using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// BillPaymentDetail Data Structure.
    /// </summary>
    public class BillPaymentDetail : AlipayObject
    {
        /// <summary>
        /// 缴费项ID
        /// </summary>
        [JsonPropertyName("bill_payment_id")]
        public string BillPaymentId { get; set; }
    }
}
