using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaOpenAppHylabeltwoQueryResponse.
    /// </summary>
    public class ZhimaOpenAppHylabeltwoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 行业分类概率列表
        /// </summary>
        [JsonPropertyName("hylabel_list")]
        public List<Hylabel> HylabelList { get; set; }
    }
}
