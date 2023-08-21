using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppProdmodeChargeoffinstQueryResponse.
    /// </summary>
    public class AlipayEbppProdmodeChargeoffinstQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 销账机构下拉列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<BizListDataInfo> DataList { get; set; }
    }
}
