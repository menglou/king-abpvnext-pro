using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingUserulePidQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingUserulePidQueryModel : AlipayObject
    {
        /// <summary>
        /// 合作伙伴ID，传入ID比如与当前APPID所属合作伙伴ID一致，否则会报权限不足
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
