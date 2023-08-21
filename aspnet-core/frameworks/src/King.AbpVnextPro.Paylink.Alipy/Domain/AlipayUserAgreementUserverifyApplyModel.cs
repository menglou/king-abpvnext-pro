using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserAgreementUserverifyApplyModel Data Structure.
    /// </summary>
    public class AlipayUserAgreementUserverifyApplyModel : AlipayObject
    {
        /// <summary>
        /// 协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }
    }
}
