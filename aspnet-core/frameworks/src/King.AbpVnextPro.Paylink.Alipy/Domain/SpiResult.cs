using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SpiResult Data Structure.
    /// </summary>
    public class SpiResult : AlipayObject
    {
        /// <summary>
        /// isv自定义业务代码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// spi唯一id
        /// </summary>
        [JsonPropertyName("spi_id")]
        public long SpiId { get; set; }
    }
}
