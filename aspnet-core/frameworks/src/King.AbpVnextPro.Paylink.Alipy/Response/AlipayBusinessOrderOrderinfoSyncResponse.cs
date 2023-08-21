using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBusinessOrderOrderinfoSyncResponse.
    /// </summary>
    public class AlipayBusinessOrderOrderinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 订单id
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
