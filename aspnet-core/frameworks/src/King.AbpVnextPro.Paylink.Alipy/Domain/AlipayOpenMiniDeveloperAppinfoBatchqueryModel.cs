using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniDeveloperAppinfoBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDeveloperAppinfoBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 客户端标识
        /// </summary>
        [JsonPropertyName("bundle_id")]
        public string BundleId { get; set; }
    }
}
