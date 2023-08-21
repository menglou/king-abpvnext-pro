using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodsBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodsBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 货品信息
        /// </summary>
        [JsonPropertyName("goods")]
        public List<GoodsVO> Goods { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public string TotalCount { get; set; }
    }
}
