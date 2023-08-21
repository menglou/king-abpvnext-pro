using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayZdatafrontDatatransferedSendResponse.
    /// </summary>
    public class AlipayZdatafrontDatatransferedSendResponse : AlipayResponse
    {
        /// <summary>
        /// 表示数据传输是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
