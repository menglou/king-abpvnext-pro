using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoEprintCodeNotifyModel Data Structure.
    /// </summary>
    public class AlipayEcoEprintCodeNotifyModel : AlipayObject
    {
        /// <summary>
        /// 授权code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 授权门店ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
