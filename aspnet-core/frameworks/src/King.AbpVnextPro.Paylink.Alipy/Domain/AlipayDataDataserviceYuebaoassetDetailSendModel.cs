using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataDataserviceYuebaoassetDetailSendModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceYuebaoassetDetailSendModel : AlipayObject
    {
        /// <summary>
        /// 资产负债报表数据列表
        /// </summary>
        [JsonPropertyName("alm_report_data")]
        public List<AlmReportData> AlmReportData { get; set; }
    }
}
