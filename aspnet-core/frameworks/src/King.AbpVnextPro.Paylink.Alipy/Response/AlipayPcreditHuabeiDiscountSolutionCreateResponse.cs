using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionCreateResponse.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionCreateResponse : AlipayResponse
    {
        /// <summary>
        /// solution_id，创建成功后返回的贴息活动方案id
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }
    }
}
