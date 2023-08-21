using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
