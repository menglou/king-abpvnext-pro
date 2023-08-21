using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTrainCourseCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateTrainCourseCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝内部课程id
        /// </summary>
        [JsonPropertyName("course_id")]
        public string CourseId { get; set; }
    }
}
