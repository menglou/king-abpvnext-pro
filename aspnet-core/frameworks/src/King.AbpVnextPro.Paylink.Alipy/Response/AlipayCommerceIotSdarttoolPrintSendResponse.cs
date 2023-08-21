using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolPrintSendResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolPrintSendResponse : AlipayResponse
    {
        /// <summary>
        /// 打印任务编号
        /// </summary>
        [JsonPropertyName("print_no")]
        public string PrintNo { get; set; }
    }
}
