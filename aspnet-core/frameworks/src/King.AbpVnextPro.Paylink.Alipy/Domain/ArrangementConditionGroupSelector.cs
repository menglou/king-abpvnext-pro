using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ArrangementConditionGroupSelector Data Structure.
    /// </summary>
    public class ArrangementConditionGroupSelector : AlipayObject
    {
        /// <summary>
        /// 是否选择最新的产品条件,默认为TRUE
        /// </summary>
        [JsonPropertyName("select_latest_pd_cd")]
        public bool SelectLatestPdCd { get; set; }
    }
}
