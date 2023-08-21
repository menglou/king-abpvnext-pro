using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossProdElecsealOrderApplyResponse.
    /// </summary>
    public class AlipayBossProdElecsealOrderApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 法务中台电子用印流水号
        /// </summary>
        [JsonPropertyName("seal_request_id")]
        public string SealRequestId { get; set; }
    }
}
