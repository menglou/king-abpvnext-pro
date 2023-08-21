using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotServiceutilBuildtextSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotServiceutilBuildtextSendModel : AlipayObject
    {
        /// <summary>
        /// 要合成语音文件的文本
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
