using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KeyanColumn Data Structure.
    /// </summary>
    public class KeyanColumn : AlipayObject
    {
        /// <summary>
        /// 密码
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
