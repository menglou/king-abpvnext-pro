using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarMaintainDataUpdateResponse.
    /// </summary>
    public class AlipayEcoMycarMaintainDataUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 具体返回的处理结果
        /// </summary>
        [JsonPropertyName("info")]
        public string Info { get; set; }
    }
}
