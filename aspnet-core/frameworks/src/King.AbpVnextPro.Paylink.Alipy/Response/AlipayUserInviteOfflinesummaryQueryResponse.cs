using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayUserInviteOfflinesummaryQueryResponse.
    /// </summary>
    public class AlipayUserInviteOfflinesummaryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 线下拉新结算汇总数据列表
        /// </summary>
        [JsonPropertyName("offline_summary_info_list")]
        public List<OfflineInviteNewerSummaryInfo> OfflineSummaryInfoList { get; set; }
    }
}
