using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaMerchantContractOfferQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantContractOfferQueryModel : AlipayObject
    {
        /// <summary>
        /// 发约单单号
        /// </summary>
        [JsonPropertyName("offer_no")]
        public string OfferNo { get; set; }
    }
}
