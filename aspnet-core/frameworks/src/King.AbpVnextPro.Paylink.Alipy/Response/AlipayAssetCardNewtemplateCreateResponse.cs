using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAssetCardNewtemplateCreateResponse.
    /// </summary>
    public class AlipayAssetCardNewtemplateCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
