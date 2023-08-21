using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniBrandBundleQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniBrandBundleQueryModel : AlipayObject
    {
        /// <summary>
        /// 所需查询的小程序id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
