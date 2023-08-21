using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditSupplychainPrepaymentCancelResponse.
    /// </summary>
    public class MybankCreditSupplychainPrepaymentCancelResponse : AlipayResponse
    {
        /// <summary>
        /// 受理事件单编号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
