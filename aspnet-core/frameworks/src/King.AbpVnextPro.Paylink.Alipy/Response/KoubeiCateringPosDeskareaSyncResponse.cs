using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDeskareaSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 返回主键
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
