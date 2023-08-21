using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingRecruitEnrollCloseModel Data Structure.
    /// </summary>
    public class AlipayMarketingRecruitEnrollCloseModel : AlipayObject
    {
        /// <summary>
        /// 报名ID
        /// </summary>
        [JsonPropertyName("enroll_id")]
        public string EnrollId { get; set; }
    }
}
