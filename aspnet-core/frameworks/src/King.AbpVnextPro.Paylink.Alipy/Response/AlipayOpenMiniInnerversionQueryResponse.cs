using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniInnerversionQueryResponse.
    /// </summary>
    public class AlipayOpenMiniInnerversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 版本列表
        /// </summary>
        [JsonPropertyName("version_list")]
        public List<MiniAppVersionBaseInfo> VersionList { get; set; }
    }
}
