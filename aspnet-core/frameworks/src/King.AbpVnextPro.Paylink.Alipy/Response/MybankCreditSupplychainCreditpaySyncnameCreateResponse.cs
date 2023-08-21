using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditSupplychainCreditpaySyncnameCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainCreditpaySyncnameCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务序列号
        /// </summary>
        [JsonPropertyName("ev_seq_no")]
        public string EvSeqNo { get; set; }
    }
}
