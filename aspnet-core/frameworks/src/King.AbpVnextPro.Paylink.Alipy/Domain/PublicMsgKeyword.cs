using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PublicMsgKeyword Data Structure.
    /// </summary>
    public class PublicMsgKeyword : AlipayObject
    {
        /// <summary>
        /// 模板关键字名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
