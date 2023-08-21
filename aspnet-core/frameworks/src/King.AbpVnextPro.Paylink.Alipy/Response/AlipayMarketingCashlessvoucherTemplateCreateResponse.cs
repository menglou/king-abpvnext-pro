using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMarketingCashlessvoucherTemplateCreateResponse.
    /// </summary>
    public class AlipayMarketingCashlessvoucherTemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
