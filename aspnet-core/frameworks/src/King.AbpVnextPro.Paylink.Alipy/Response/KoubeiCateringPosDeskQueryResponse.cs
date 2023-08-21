using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDeskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 餐台信息
        /// </summary>
        [JsonPropertyName("pos_desk_list")]
        public List<DeskEntity> PosDeskList { get; set; }
    }
}
