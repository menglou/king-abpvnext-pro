using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiSalesLeadsShopleadsCreateResponse.
    /// </summary>
    public class KoubeiSalesLeadsShopleadsCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 导入成功的LeadsId
        /// </summary>
        [JsonPropertyName("leads_id")]
        public string LeadsId { get; set; }
    }
}
