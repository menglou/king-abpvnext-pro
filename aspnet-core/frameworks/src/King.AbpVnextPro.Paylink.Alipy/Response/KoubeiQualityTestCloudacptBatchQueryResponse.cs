using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptBatchQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptBatchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次列表
        /// </summary>
        [JsonPropertyName("batch_list")]
        public List<OpenBatch> BatchList { get; set; }

        /// <summary>
        /// 单品批次数
        /// </summary>
        [JsonPropertyName("batch_num")]
        public string BatchNum { get; set; }
    }
}
