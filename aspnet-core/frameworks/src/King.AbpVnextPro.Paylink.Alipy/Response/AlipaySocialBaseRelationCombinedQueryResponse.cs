using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseRelationCombinedQueryResponse.
    /// </summary>
    public class AlipaySocialBaseRelationCombinedQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 复合关系数据
        /// </summary>
        [JsonPropertyName("relation_combined_list")]
        public List<RelationCombinedVO> RelationCombinedList { get; set; }
    }
}
