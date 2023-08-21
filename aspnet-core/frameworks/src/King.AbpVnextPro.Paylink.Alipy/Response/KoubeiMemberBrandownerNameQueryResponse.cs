using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMemberBrandownerNameQueryResponse.
    /// </summary>
    public class KoubeiMemberBrandownerNameQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 品牌商名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
