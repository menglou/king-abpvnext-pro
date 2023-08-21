using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringPosDishQueryResponse.
    /// </summary>
    public class KoubeiCateringPosDishQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 口碑盒子菜品的详情
        /// </summary>
        [JsonPropertyName("pos_dish_qry_model")]
        public PosDishQryModel PosDishQryModel { get; set; }
    }
}
