using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppApiFieldQueryResponse.
    /// </summary>
    public class AlipayOpenAppApiFieldQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息申请信息记录查询响应模型
        /// </summary>
        [JsonPropertyName("auth_field_response")]
        public AuthFieldResponse AuthFieldResponse { get; set; }
    }
}
