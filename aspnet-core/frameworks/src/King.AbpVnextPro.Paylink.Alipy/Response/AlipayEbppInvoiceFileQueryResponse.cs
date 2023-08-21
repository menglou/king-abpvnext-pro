using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppInvoiceFileQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceFileQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票文件内容,需要先base64解码，获取原始byte[]类型文件流
        /// </summary>
        [JsonPropertyName("invoice_file_content")]
        public string InvoiceFileContent { get; set; }
    }
}
