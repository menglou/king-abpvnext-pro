using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiTradeBillDownloadurlQueryResponse.
    /// </summary>
    public class KoubeiTradeBillDownloadurlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单下载地址
        /// </summary>
        [JsonPropertyName("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
