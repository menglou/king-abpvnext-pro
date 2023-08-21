using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiTradeTicketUserticketcodeQueryResponse.
    /// </summary>
    public class KoubeiTradeTicketUserticketcodeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询结果列表
        /// </summary>
        [JsonPropertyName("values")]
        public List<TicketCodeQueryResponse> Values { get; set; }
    }
}
