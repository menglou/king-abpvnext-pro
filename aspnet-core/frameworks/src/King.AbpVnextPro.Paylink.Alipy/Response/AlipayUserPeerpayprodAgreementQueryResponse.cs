using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementQueryResponse.
    /// </summary>
    public class AlipayUserPeerpayprodAgreementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 亲情号协议的额度
        /// </summary>
        [JsonPropertyName("quota")]
        public long Quota { get; set; }
    }
}
