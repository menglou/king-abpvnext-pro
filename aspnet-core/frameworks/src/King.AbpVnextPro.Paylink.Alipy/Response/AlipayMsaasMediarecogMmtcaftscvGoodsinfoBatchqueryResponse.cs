using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvGoodsinfoBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonPropertyName("goods_infos")]
        public List<AlgorithmGoodsInfo> GoodsInfos { get; set; }
    }
}
