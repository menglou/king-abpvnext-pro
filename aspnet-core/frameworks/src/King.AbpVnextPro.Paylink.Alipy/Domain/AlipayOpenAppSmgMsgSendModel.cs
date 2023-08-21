using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppSmgMsgSendModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSmgMsgSendModel : AlipayObject
    {
        /// <summary>
        /// 5555
        /// </summary>
        [JsonPropertyName("numberone")]
        public string Numberone { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [JsonPropertyName("numbertowe")]
        public string Numbertowe { get; set; }
    }
}
