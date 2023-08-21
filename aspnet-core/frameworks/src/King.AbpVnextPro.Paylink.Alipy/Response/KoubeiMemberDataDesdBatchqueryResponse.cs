using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMemberDataDesdBatchqueryResponse.
    /// </summary>
    public class KoubeiMemberDataDesdBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("de")]
        public GavintestNewonline De { get; set; }
    }
}
