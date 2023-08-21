using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// HSchoolInfo Data Structure.
    /// </summary>
    public class HSchoolInfo : AlipayObject
    {
        /// <summary>
        /// 学号
        /// </summary>
        [JsonPropertyName("campus_no")]
        public string CampusNo { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        [JsonPropertyName("school_std_code")]
        public string SchoolStdCode { get; set; }
    }
}
