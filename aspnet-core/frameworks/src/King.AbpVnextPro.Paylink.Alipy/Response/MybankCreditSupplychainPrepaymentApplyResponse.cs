using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentApplyResponse.
    /// </summary>
    public class MybankCreditSupplychainPrepaymentApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 预付申请单编号。
        /// </summary>
        [JsonPropertyName("prepayment_apply_no")]
        public string PrepaymentApplyNo { get; set; }
    }
}
