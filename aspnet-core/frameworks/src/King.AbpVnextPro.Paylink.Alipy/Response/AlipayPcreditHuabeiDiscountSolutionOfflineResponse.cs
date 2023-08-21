using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOfflineResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 贴息方案是否下架成功，true下架成功，false下架失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
