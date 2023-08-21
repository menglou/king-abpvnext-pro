using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceGoodsVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceGoodsVoucherBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [JsonPropertyName("activities")]
        public List<CampVoucherInfo> Activities { get; set; }
    }
}
