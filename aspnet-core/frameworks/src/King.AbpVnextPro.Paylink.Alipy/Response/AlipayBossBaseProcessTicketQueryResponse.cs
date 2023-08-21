using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryResponse.
    /// </summary>
    public class AlipayBossBaseProcessTicketQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 工单详情
        /// </summary>
        [JsonPropertyName("ticket")]
        public BPOpenApiTicket Ticket { get; set; }
    }
}
