using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppCommunityServiceQueryResponse.
    /// </summary>
    public class AlipayEbppCommunityServiceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务查询列表
        /// </summary>
        [JsonPropertyName("service_info_list")]
        public List<CommunityServiceInfo> ServiceInfoList { get; set; }
    }
}
