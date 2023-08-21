using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotSnRuleQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSnRuleQueryModel : AlipayObject
    {
        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 厂商id
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
