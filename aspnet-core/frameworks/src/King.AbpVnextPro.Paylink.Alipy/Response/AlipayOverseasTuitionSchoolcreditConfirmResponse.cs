using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTuitionSchoolcreditConfirmResponse.
    /// </summary>
    public class AlipayOverseasTuitionSchoolcreditConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 业务透传保留字段，json map格式
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
