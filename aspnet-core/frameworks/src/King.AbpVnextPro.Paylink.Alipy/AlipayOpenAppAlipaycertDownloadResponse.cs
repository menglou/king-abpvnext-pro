using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy
{
    public class AlipayOpenAppAlipaycertDownloadResponse : AlipayResponse
    {
        [JsonPropertyName("alipay_cert_content")]
        public string AlipayCertContent { get; set; }
    }
}
