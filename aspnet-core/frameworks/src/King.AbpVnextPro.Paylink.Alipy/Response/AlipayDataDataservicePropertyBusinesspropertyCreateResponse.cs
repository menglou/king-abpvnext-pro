using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataservicePropertyBusinesspropertyCreateResponse.
    /// </summary>
    public class AlipayDataDataservicePropertyBusinesspropertyCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务画像标签id
        /// </summary>
        [JsonPropertyName("business_property_id")]
        public string BusinessPropertyId { get; set; }
    }
}
