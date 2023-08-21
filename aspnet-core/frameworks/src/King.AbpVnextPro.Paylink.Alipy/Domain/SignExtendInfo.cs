using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// SignExtendInfo Data Structure.
    /// </summary>
    public class SignExtendInfo : AlipayObject
    {
        /// <summary>
        /// isv 商户id
        /// </summary>
        [JsonPropertyName("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
