using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiServindustryPortfolioOpusBatchqueryResponse.
    /// </summary>
    public class KoubeiServindustryPortfolioOpusBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 素材列表
        /// </summary>
        [JsonPropertyName("opuses")]
        public List<OpusInfo> Opuses { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_size")]
        public long TotalSize { get; set; }
    }
}
