using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionSpecialadvcontentModifyResponse.
    /// </summary>
    public class KoubeiAdvertCommissionSpecialadvcontentModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改特殊广告内容的返回结果
        /// </summary>
        [JsonPropertyName("data")]
        public List<KbAdvertSpecialAdvContentModifyResponse> Data { get; set; }
    }
}
