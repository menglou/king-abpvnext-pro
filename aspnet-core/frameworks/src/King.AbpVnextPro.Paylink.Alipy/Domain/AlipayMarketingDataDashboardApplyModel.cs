using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingDataDashboardApplyModel Data Structure.
    /// </summary>
    public class AlipayMarketingDataDashboardApplyModel : AlipayObject
    {
        /// <summary>
        /// 仪表盘ID列表
        /// </summary>
        [JsonPropertyName("dashboard_ids")]
        public List<string> DashboardIds { get; set; }
    }
}
