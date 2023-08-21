using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditCreditriskGuarschemeQueryResponse.
    /// </summary>
    public class MybankCreditCreditriskGuarschemeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [JsonPropertyName("admit")]
        public bool Admit { get; set; }

        /// <summary>
        /// 可用担保额度
        /// </summary>
        [JsonPropertyName("available_amt")]
        public string AvailableAmt { get; set; }
    }
}
