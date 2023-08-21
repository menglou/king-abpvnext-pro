using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityDataInfoMobilecityQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityDataInfoMobilecityQueryModel : AlipayObject
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
    }
}
