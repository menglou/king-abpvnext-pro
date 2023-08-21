using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicTopicBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicTopicBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 营销位列表
        /// </summary>
        [JsonPropertyName("topic_list")]
        public List<Topic> TopicList { get; set; }
    }
}
