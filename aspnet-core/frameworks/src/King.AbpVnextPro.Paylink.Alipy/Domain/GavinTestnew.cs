using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// GavinTestnew Data Structure.
    /// </summary>
    public class GavinTestnew : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("test")]
        public string Test { get; set; }
    }
}
