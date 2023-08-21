using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskCreateResponse.
    /// </summary>
    public class KoubeiCateringPosDeskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 桌位ID
        /// </summary>
        [JsonPropertyName("ids")]
        public List<string> Ids { get; set; }
    }
}
