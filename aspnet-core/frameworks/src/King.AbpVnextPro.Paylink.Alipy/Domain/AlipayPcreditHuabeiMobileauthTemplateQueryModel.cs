using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiMobileauthTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiMobileauthTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求参数
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
