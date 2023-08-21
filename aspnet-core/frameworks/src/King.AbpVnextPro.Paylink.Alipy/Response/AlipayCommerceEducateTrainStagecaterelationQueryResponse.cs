using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainStagecaterelationQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainStagecaterelationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 学段分组信息
        /// </summary>
        [JsonPropertyName("stage_group_infos")]
        public List<StageGroupInfoVO> StageGroupInfos { get; set; }
    }
}
