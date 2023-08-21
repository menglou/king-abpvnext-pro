using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingUserulePidQueryResponse.
    /// </summary>
    public class AlipayMarketingUserulePidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 满足条件的所有pid，多个pid使用英文逗号隔开
        /// </summary>
        [JsonPropertyName("pids")]
        public string Pids { get; set; }
    }
}
