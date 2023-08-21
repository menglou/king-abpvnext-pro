using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserPassTemplateCreateResponse.
    /// </summary>
    public class AlipayUserPassTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝模版ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
