using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySamsungEbppRechargeResponse.
    /// </summary>
    public class AlipaySamsungEbppRechargeResponse : AlipayResponse
    {
        /// <summary>
        /// 直接返回页面
        /// </summary>
        [JsonPropertyName("page_retrun")]
        public string PageRetrun { get; set; }
    }
}
