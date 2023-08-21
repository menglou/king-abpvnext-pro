using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailWmsGoodsQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsGoodsQueryResponse : AlipayResponse
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
        public long TotalCount { get; set; }
    }
}
