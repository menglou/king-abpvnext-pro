using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCardTemplateModifyResponse.
    /// </summary>
    public class AlipayMarketingCardTemplateModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
