﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMarketingDataMemberReportQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataMemberReportQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询成功时返回json格式数据
        /// </summary>
        [JsonPropertyName("report_data")]
        public string ReportData { get; set; }
    }
}
