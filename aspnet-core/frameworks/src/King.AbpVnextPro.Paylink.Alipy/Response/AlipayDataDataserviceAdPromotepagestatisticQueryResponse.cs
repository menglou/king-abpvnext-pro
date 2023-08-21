using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepagestatisticQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepagestatisticQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 留资统计列表
        /// </summary>
        [JsonPropertyName("collectinfo_list")]
        public List<PromotePageStatistic> CollectinfoList { get; set; }
    }
}
