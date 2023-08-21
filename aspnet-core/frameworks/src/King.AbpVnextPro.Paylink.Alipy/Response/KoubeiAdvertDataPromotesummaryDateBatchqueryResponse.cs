using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiAdvertDataPromotesummaryDateBatchqueryResponse.
    /// </summary>
    public class KoubeiAdvertDataPromotesummaryDateBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑客推广日期维度汇总数据
        /// </summary>
        [JsonPropertyName("data")]
        public List<PromoteDateModel> Data { get; set; }
    }
}
