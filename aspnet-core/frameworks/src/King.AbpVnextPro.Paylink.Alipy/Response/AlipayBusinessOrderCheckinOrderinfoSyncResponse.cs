using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBusinessOrderCheckinOrderinfoSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderCheckinOrderinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 行业侧入住单唯一标识
        /// </summary>
        [JsonPropertyName("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
