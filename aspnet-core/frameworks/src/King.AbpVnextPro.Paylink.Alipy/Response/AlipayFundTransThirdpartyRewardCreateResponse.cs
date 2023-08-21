using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardCreateResponse.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 打赏单据号
        /// </summary>
        [JsonPropertyName("transfer_no")]
        public string TransferNo { get; set; }
    }
}
