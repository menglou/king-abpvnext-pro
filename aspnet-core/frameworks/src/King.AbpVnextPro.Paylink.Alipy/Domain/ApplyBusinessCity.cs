using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ApplyBusinessCity Data Structure.
    /// </summary>
    public class ApplyBusinessCity : AlipayObject
    {
        /// <summary>
        /// 业务归属地区编码,精确到区县
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 投保地区用户选择的层级
        /// </summary>
        [JsonPropertyName("city_level")]
        public string CityLevel { get; set; }
    }
}
