using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayWeiboEbppRechargeResponse.
    /// </summary>
    public class AlipayWeiboEbppRechargeResponse : AlipayResponse
    {
        /// <summary>
        /// 返回缴费页面
        /// </summary>
        [JsonPropertyName("partnerpuccharge")]
        public string Partnerpuccharge { get; set; }
    }
}
