using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainTagsQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainTagsQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 标签信息列表
        /// </summary>
        [JsonPropertyName("tag_infos")]
        public List<TagInfoVO> TagInfos { get; set; }
    }
}
