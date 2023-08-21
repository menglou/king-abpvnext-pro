using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipaySocialAntforestTreeSyncResponse.
    /// </summary>
    public class AlipaySocialAntforestTreeSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步是否成功
        /// </summary>
        [JsonPropertyName("synced")]
        public bool Synced { get; set; }
    }
}
