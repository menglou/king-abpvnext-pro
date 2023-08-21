using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayAccountExrateCollectcoreDataSendModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateCollectcoreDataSendModel : AlipayObject
    {
        /// <summary>
        /// 上数提交数据内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
