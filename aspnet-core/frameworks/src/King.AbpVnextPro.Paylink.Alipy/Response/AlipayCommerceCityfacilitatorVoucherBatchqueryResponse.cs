using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorVoucherBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的订单信息列表
        /// </summary>
        [JsonPropertyName("tickets")]
        public List<TicketDetailInfo> Tickets { get; set; }
    }
}
