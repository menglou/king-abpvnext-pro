using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMultimediaXnnminiModelCreateResponse.
    /// </summary>
    public class AlipayMultimediaXnnminiModelCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 模型id
        /// </summary>
        [JsonPropertyName("model_id")]
        public string ModelId { get; set; }
    }
}
