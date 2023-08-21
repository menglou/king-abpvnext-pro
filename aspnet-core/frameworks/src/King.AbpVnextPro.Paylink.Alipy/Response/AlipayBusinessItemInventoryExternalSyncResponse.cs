using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBusinessItemInventoryExternalSyncResponse.
    /// </summary>
    public class AlipayBusinessItemInventoryExternalSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝商品id列表
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 入参中的request_id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
