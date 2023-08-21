using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserPassTemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayUserPassTemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝模版ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
