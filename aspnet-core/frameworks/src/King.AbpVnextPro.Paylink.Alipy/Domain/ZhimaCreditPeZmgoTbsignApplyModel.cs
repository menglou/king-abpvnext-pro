using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditPeZmgoTbsignApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeZmgoTbsignApplyModel : AlipayObject
    {
        /// <summary>
        /// 请求参数，其中paramContent为base64编码串
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
