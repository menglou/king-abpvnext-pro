using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAccountClearingcenterPayoffModifyResponse.
    /// </summary>
    public class AlipayAccountClearingcenterPayoffModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("result")]
        public ClearingCommonResult Result { get; set; }
    }
}
