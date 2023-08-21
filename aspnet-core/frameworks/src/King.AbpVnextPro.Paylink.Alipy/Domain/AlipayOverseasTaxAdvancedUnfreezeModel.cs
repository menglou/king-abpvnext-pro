using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedUnfreezeModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxAdvancedUnfreezeModel : AlipayObject
    {
        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [JsonPropertyName("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
