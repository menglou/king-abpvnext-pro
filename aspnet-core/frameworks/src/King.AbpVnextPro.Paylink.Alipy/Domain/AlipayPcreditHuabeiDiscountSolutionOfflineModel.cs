using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiDiscountSolutionOfflineModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiDiscountSolutionOfflineModel : AlipayObject
    {
        /// <summary>
        /// solution_id，贴息方案实例id
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }
    }
}
