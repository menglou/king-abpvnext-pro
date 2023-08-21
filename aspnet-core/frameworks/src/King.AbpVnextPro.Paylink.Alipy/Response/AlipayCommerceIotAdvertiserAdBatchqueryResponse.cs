using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotAdvertiserAdBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投放计划列表数组
        /// </summary>
        [JsonPropertyName("result")]
        public List<CreationPlanData> Result { get; set; }

        /// <summary>
        /// 计划总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
