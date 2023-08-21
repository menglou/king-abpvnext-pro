using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandItemStatusModifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品状态：EFFECT、INVALID
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
