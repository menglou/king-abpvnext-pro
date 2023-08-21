using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCardOpenApplyResponse.
    /// </summary>
    public class AlipayMarketingCardOpenApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 商户卡信息（包括支付宝分配的业务卡号）
        /// </summary>
        [JsonPropertyName("card_info")]
        public MerchantCard CardInfo { get; set; }
    }
}
