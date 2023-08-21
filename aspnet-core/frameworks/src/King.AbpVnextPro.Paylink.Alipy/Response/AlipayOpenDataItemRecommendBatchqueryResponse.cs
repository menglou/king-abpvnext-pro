using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenDataItemRecommendBatchqueryResponse.
    /// </summary>
    public class AlipayOpenDataItemRecommendBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐结果
        /// </summary>
        [JsonPropertyName("result_obj")]
        public List<RecResultInfo> ResultObj { get; set; }
    }
}
