using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodecountResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodecountResponse : AlipayResponse
    {
        /// <summary>
        /// 已经导入的券码数量
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
