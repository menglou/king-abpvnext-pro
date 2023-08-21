using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonPropertyName("label_id")]
        public string LabelId { get; set; }
    }
}
