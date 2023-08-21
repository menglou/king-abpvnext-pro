using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceOperationGamemarketingBenefitVerifyResponse.
    /// </summary>
    public class AlipayCommerceOperationGamemarketingBenefitVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 卡券核销状态
        /// </summary>
        [JsonPropertyName("voucher_verify_status")]
        public bool VoucherVerifyStatus { get; set; }
    }
}
