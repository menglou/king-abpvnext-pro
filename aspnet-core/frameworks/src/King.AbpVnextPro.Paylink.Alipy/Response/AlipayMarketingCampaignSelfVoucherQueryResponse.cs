using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfVoucherQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfVoucherQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券列表
        /// </summary>
        [JsonPropertyName("voucher_item")]
        public VoucherItem VoucherItem { get; set; }
    }
}
