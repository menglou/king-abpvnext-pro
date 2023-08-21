using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ErrorMatcher Data Structure.
    /// </summary>
    public class ErrorMatcher : AlipayObject
    {
        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 用户打标接口出错的匹配器
        /// </summary>
        [JsonPropertyName("matcher")]
        public Matcher Matcher { get; set; }
    }
}
