using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecuritySssssssQueryModel Data Structure.
    /// </summary>
    public class AlipaySecuritySssssssQueryModel : AlipayObject
    {
        /// <summary>
        /// 金额
        /// </summary>
        [JsonPropertyName("ddd")]
        public string Ddd { get; set; }

        /// <summary>
        /// 阿法
        /// </summary>
        [JsonPropertyName("x_adfa")]
        public string XAdfa { get; set; }
    }
}
