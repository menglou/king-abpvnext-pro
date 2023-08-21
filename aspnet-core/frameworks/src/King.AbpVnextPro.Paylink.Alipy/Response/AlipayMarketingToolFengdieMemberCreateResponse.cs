using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieMemberCreateResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieMemberCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 凤蝶业务空间创建成功后，返回该成员的基本信息
        /// </summary>
        [JsonPropertyName("data")]
        public FengdieSpaceMemberCreateModel Data { get; set; }
    }
}
