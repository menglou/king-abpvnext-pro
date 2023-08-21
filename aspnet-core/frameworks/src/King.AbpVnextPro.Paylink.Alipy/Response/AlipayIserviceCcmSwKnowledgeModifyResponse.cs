using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayIserviceCcmSwKnowledgeModifyResponse.
    /// </summary>
    public class AlipayIserviceCcmSwKnowledgeModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 知识点ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
