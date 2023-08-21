using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySocialForestSimplecertificateQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialForestSimplecertificateQueryModel : AlipayObject
    {
        /// <summary>
        /// 年份
        /// </summary>
        [JsonPropertyName("year")]
        public string Year { get; set; }
    }
}
