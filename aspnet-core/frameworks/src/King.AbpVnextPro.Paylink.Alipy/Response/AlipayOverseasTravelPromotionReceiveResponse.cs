using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOverseasTravelPromotionReceiveResponse.
    /// </summary>
    public class AlipayOverseasTravelPromotionReceiveResponse : AlipayResponse
    {
        /// <summary>
        /// 券平台领券成功的券id
        /// </summary>
        [JsonPropertyName("out_prize_id")]
        public string OutPrizeId { get; set; }
    }
}
