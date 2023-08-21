using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossProdProtocolOrderPreviewResponse.
    /// </summary>
    public class AlipayBossProdProtocolOrderPreviewResponse : AlipayResponse
    {
        /// <summary>
        /// 协议预览结果
        /// </summary>
        [JsonPropertyName("protocol_preview_vo_list")]
        public ProtocolPreviewVO ProtocolPreviewVoList { get; set; }
    }
}
