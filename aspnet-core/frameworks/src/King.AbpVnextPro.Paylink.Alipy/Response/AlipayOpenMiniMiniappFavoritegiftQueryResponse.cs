using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappFavoritegiftQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappFavoritegiftQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 收藏有礼查询用户对应小程序的查询结果列表
        /// </summary>
        [JsonPropertyName("result_list")]
        public List<ActivityQueryResult> ResultList { get; set; }
    }
}
