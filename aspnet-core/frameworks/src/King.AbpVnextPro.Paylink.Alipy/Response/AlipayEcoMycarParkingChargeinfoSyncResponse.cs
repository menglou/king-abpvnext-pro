using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEcoMycarParkingChargeinfoSyncResponse.
    /// </summary>
    public class AlipayEcoMycarParkingChargeinfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步结果：0 成功，1 失败
        /// </summary>
        [JsonPropertyName("sync_result")]
        public string SyncResult { get; set; }
    }
}
