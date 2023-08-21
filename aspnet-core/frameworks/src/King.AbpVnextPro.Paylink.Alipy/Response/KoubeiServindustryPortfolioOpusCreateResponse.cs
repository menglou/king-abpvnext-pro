using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusCreateResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品列表
        /// </summary>
        [JsonPropertyName("opuses")]
        public OpusCreateResponse Opuses { get; set; }
    }
}
