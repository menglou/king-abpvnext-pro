using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppApiQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 应用可申请的接口出参敏感字段列表
        /// </summary>
        [JsonPropertyName("apis")]
        public List<AuthApiDTO> Apis { get; set; }
    }
}
