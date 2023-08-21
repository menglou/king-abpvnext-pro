using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CourseTagInfo Data Structure.
    /// </summary>
    public class CourseTagInfo : AlipayObject
    {
        /// <summary>
        /// 标签code (从标签列表接口选取)
        /// </summary>
        [JsonPropertyName("tag_code")]
        public string TagCode { get; set; }
    }
}
