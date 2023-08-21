using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiItemExtitemInfoQueryResponse.
    /// </summary>
    public class KoubeiItemExtitemInfoQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 外部商品信息
        /// </summary>
        [JsonPropertyName("kb_ext_item_info")]
        public KbExtItemInfo KbExtItemInfo { get; set; }
    }
}
