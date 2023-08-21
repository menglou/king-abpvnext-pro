using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingVoucherListQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 券列表，一定不为null，但是size可以为0
        /// </summary>
        [JsonPropertyName("vouchers")]
        public List<VoucherLiteInfo> Vouchers { get; set; }
    }
}
