using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAccountInstfundWithdrawApplyResponse.
    /// </summary>
    public class AlipayAccountInstfundWithdrawApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 资金指令唯一标识
        /// </summary>
        [JsonPropertyName("instruction_no")]
        public string InstructionNo { get; set; }
    }
}
