using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationIssueConfirmResponse.
    /// </summary>
    public class AlipayInsSceneApplicationIssueConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }
    }
}
