using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonConsultResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodCommonConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 具体内容按照业务类型对应的key值传输
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }
    }
}
