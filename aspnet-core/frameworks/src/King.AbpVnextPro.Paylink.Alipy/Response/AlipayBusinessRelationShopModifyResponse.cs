using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBusinessRelationShopModifyResponse.
    /// </summary>
    public class AlipayBusinessRelationShopModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 基于商业关系的代运营门店id
        /// </summary>
        [JsonPropertyName("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
