using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// LegalRepresentativeVO Data Structure.
    /// </summary>
    public class LegalRepresentativeVO : AlipayObject
    {
        /// <summary>
        /// 职务
        /// </summary>
        [JsonPropertyName("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
