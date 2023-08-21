using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignConsultModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignConsultModel : AlipayObject
    {
        /// <summary>
        /// 请求参数，其中paramContent的值为base64编码串
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
