using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoCityserviceUserPropertiesSendResponse.
    /// </summary>
    public class AlipayEcoCityserviceUserPropertiesSendResponse : AlipayResponse
    {
        /// <summary>
        /// 数据同步结果
        /// </summary>
        [JsonPropertyName("sync_result")]
        public string SyncResult { get; set; }
    }
}
