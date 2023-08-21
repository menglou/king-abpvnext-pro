using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AntfortuneContentCommunityTopicListQueryResponse.
    /// </summary>
    public class AntfortuneContentCommunityTopicListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 话题VO列表
        /// </summary>
        [JsonPropertyName("topic_list")]
        public List<TopicItemVo> TopicList { get; set; }
    }
}
