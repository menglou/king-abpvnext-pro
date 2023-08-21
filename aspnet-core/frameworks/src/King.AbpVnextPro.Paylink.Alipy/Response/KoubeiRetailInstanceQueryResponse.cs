using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiRetailInstanceQueryResponse.
    /// </summary>
    public class KoubeiRetailInstanceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户维度券或者DM信息列表
        /// </summary>
        [JsonPropertyName("instance_list")]
        public List<InstanceInfo> InstanceList { get; set; }

        /// <summary>
        /// 返回的总记录数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
