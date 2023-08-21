using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindResponse.
    /// </summary>
    public class KoubeiMarketingMallTradeBindResponse : AlipayResponse
    {
        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
