using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossCsDatacollectSendModel Data Structure.
    /// </summary>
    public class AlipayBossCsDatacollectSendModel : AlipayObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
