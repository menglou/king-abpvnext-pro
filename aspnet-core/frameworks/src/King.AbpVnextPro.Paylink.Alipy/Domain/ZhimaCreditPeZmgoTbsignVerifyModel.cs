using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignVerifyModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignVerifyModel : AlipayObject
    {
        /// <summary>
        /// 请求参数，其中paramContent是base64编码串
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
