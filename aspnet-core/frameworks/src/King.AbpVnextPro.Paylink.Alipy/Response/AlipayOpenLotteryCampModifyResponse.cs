using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenLotteryCampModifyResponse.
    /// </summary>
    public class AlipayOpenLotteryCampModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 抽奖活动ID
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
