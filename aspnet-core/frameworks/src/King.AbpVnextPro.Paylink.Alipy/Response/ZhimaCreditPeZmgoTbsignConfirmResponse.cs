using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConfirmResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 签约确认返回的JSON信息
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
