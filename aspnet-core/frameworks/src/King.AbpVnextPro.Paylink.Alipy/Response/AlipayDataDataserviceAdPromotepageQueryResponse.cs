using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdPromotepageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 留资页信息列表
        /// </summary>
        [JsonPropertyName("list")]
        public List<PromotePage> List { get; set; }
    }
}
