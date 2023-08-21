using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicMenuDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicMenuDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜单分析数据列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<MenuAnalysisData> DataList { get; set; }
    }
}
