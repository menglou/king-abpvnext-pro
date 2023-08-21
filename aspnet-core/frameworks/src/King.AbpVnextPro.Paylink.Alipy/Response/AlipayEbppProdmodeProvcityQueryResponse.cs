using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppProdmodeProvcityQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeProvcityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回省市下拉列表数据
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<QueryProvCityInfo> DataList { get; set; }
    }
}
