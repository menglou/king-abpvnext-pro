using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ReduceToAmtDstCampPrizeModel Data Structure.
    /// </summary>
    public class ReduceToAmtDstCampPrizeModel : AlipayObject
    {
        /// <summary>
        /// 优惠后价格
        /// </summary>
        [JsonPropertyName("reduct_to_amt")]
        public string ReductToAmt { get; set; }
    }
}
