using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskareaQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDeskareaQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 餐区信息
        /// </summary>
        [JsonPropertyName("pos_desk_area_list")]
        public List<DeskAreaEntity> PosDeskAreaList { get; set; }
    }
}
