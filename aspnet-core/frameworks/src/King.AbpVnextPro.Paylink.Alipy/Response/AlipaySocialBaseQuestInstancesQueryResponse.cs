using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialBaseQuestInstancesQueryResponse.
    /// </summary>
    public class AlipaySocialBaseQuestInstancesQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户实例的查询结果集
        /// </summary>
        [JsonPropertyName("instances")]
        public List<QuestInstanceDTO> Instances { get; set; }
    }
}
