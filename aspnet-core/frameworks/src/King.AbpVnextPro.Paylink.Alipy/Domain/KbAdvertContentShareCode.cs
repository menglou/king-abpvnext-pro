using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KbAdvertContentShareCode Data Structure.
    /// </summary>
    public class KbAdvertContentShareCode : AlipayObject
    {
        /// <summary>
        /// 吱口令内容详情
        /// </summary>
        [JsonPropertyName("share_code_desc")]
        public string ShareCodeDesc { get; set; }
    }
}
