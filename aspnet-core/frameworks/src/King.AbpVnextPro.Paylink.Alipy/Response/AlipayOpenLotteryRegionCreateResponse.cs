using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionCreateResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 商家入驻ID
        /// </summary>
        [JsonPropertyName("region_id")]
        public string RegionId { get; set; }
    }
}
