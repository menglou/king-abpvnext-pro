using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeApplySendResponse.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeApplySendResponse : AlipayResponse
    {
        /// <summary>
        /// 申请id
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }
    }
}
