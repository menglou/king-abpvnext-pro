using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券详情列表
        /// </summary>
        [JsonPropertyName("vouchers")]
        public List<VoucherDetailVO> Vouchers { get; set; }
    }
}
