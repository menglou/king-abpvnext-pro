using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceAudioQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotDeviceAudioQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备的唯一标识,设备id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
