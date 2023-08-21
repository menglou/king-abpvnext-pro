using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// OverseasExtendParams Data Structure.
    /// </summary>
    public class OverseasExtendParams : AlipayObject
    {
        /// <summary>
        /// 商品明细列表
        /// </summary>
        [JsonPropertyName("goods_detail")]
        public string GoodsDetail { get; set; }
    }
}
