using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditagreementSignResponse.
    /// </summary>
    public class ZhimaCreditPayafteruseCreditagreementSignResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻后付开通协议号
        /// </summary>
        [JsonPropertyName("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        [JsonPropertyName("out_agreement_no")]
        public string OutAgreementNo { get; set; }
    }
}
