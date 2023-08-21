using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAuthAppContentQueryResponse.
    /// </summary>
    public class AlipayOpenAuthAppContentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 授权协议列表
        /// </summary>
        [JsonPropertyName("agreement")]
        public List<Agreement> Agreement { get; set; }

        /// <summary>
        /// 授权范围描述
        /// </summary>
        [JsonPropertyName("auth_text")]
        public List<string> AuthText { get; set; }
    }
}
