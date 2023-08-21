using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserFamilyShareAdmittancePreconsultResponse.
    /// </summary>
    public class AlipayUserFamilyShareAdmittancePreconsultResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("admittance")]
        public bool Admittance { get; set; }

        /// <summary>
        /// 不可准入的原因
        /// </summary>
        [JsonPropertyName("unadmitted_reason")]
        public string UnadmittedReason { get; set; }
    }
}
