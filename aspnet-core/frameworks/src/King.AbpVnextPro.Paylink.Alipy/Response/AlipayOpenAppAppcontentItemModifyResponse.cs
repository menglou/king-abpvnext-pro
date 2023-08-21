using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemModifyResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentItemModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
