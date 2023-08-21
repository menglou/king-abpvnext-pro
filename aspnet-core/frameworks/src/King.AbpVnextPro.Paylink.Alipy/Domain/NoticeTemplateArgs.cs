using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// NoticeTemplateArgs Data Structure.
    /// </summary>
    public class NoticeTemplateArgs : AlipayObject
    {
        /// <summary>
        /// 课程开始时间
        /// </summary>
        [JsonPropertyName("course_start_time")]
        public string CourseStartTime { get; set; }
    }
}
