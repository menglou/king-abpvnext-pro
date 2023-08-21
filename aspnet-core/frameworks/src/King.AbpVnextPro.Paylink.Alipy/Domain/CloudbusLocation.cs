using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CloudbusLocation Data Structure.
    /// </summary>
    public class CloudbusLocation : AlipayObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [JsonPropertyName("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("lng")]
        public string Lng { get; set; }
    }
}
