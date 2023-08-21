using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceIotWifiStatusQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotWifiStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备唯一id
        /// </summary>
        [JsonPropertyName("biz_tid")]
        public string BizTid { get; set; }
    }
}
