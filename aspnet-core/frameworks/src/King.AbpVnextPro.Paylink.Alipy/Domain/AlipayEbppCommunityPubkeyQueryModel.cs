using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppCommunityPubkeyQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityPubkeyQueryModel : AlipayObject
    {
        /// <summary>
        /// ISV短名(创建ISV时生成)
        /// </summary>
        [JsonPropertyName("isv_short_name")]
        public string IsvShortName { get; set; }
    }
}
