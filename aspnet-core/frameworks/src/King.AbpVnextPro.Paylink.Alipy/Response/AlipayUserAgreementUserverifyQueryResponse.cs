using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserAgreementUserverifyQueryResponse.
    /// </summary>
    public class AlipayUserAgreementUserverifyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户信息是否匹配
        /// </summary>
        [JsonPropertyName("user_match")]
        public bool UserMatch { get; set; }
    }
}
