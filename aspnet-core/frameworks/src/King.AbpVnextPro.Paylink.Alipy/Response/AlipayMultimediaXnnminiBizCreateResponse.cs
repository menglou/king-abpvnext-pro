using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMultimediaXnnminiBizCreateResponse.
    /// </summary>
    public class AlipayMultimediaXnnminiBizCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 创建业务id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }
    }
}
