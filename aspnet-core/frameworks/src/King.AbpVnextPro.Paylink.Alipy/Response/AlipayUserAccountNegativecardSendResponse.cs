using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserAccountNegativecardSendResponse.
    /// </summary>
    public class AlipayUserAccountNegativecardSendResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码。SUCCESS：发送成功。
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
