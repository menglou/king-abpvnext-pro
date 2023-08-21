using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionModifyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionModifyResponse : AlipayResponse
    {
        /// <summary>
        /// success，是否更新成功，true成功，false失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
