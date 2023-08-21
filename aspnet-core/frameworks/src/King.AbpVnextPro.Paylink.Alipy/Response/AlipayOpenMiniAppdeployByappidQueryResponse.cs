using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniAppdeployByappidQueryResponse.
    /// </summary>
    public class AlipayOpenMiniAppdeployByappidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序发布信息
        /// </summary>
        [JsonPropertyName("deploys")]
        public List<MiniAppDeployResponse> Deploys { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
