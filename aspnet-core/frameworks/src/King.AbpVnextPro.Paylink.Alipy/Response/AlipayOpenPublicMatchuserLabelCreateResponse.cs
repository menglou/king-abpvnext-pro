using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelCreateResponse.
    /// </summary>
    public class AlipayOpenPublicMatchuserLabelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 用户打标失败数量
        /// </summary>
        [JsonPropertyName("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// 出错的匹配器列表
        /// </summary>
        [JsonPropertyName("error_matchers")]
        public List<ErrorMatcher> ErrorMatchers { get; set; }
    }
}
