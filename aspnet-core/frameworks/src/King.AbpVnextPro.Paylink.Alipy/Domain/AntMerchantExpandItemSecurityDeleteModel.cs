using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandItemSecurityDeleteModel Data Structure.
    /// </summary>
    public class AntMerchantExpandItemSecurityDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
