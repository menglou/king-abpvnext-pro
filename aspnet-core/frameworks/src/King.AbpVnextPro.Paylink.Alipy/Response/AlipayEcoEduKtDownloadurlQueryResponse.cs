using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoEduKtDownloadurlQueryResponse.
    /// </summary>
    public class AlipayEcoEduKtDownloadurlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        [JsonPropertyName("bill_download_url")]
        public string BillDownloadUrl { get; set; }
    }
}
