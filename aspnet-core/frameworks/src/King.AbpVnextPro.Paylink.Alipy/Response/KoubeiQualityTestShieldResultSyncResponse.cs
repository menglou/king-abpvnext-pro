using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldResultSyncResponse.
    /// </summary>
    public class KoubeiQualityTestShieldResultSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
