using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGnameModifyModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGnameModifyModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }
    }
}
