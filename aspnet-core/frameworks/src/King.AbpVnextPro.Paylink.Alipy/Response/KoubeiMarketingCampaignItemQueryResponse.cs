using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignItemQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignItemQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品详情，包含门店信息
        /// </summary>
        [JsonPropertyName("item")]
        public PromoItemInfo Item { get; set; }
    }
}
