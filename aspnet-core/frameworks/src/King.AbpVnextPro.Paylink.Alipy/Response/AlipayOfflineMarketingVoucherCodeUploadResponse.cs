using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCodeUploadResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherCodeUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 码库id
        /// </summary>
        [JsonPropertyName("code_inventory_id")]
        public string CodeInventoryId { get; set; }
    }
}
