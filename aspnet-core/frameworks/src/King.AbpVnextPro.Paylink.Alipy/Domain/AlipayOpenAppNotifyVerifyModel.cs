using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppNotifyVerifyModel Data Structure.
    /// </summary>
    public class AlipayOpenAppNotifyVerifyModel : AlipayObject
    {
        /// <summary>
        /// 通知id
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }
    }
}
