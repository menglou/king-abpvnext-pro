using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiQualityTestShieldCaselaunchApplyResponse.
    /// </summary>
    public class KoubeiQualityTestShieldCaselaunchApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 拓展信息
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
