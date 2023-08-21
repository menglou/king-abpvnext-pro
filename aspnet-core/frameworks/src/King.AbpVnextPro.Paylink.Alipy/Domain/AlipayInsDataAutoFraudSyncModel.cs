﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayInsDataAutoFraudSyncModel Data Structure.
    /// </summary>
    public class AlipayInsDataAutoFraudSyncModel : AlipayObject
    {
        /// <summary>
        /// 减损金额，单位：元
        /// </summary>
        [JsonPropertyName("avoid_loss_amount")]
        public string AvoidLossAmount { get; set; }

        /// <summary>
        /// 减损类型，见码表《反欺诈减损类型V1》
        /// </summary>
        [JsonPropertyName("avoid_loss_type")]
        public string AvoidLossType { get; set; }

        /// <summary>
        /// 结案金额，单位：元
        /// </summary>
        [JsonPropertyName("case_end_amount")]
        public string CaseEndAmount { get; set; }

        /// <summary>
        /// 保司在案件调查时最终使用的欺诈分结果对应的查询请求号。  如果该案件未使用蚂蚁车险欺诈分查询结果，可以不传该字段。
        /// </summary>
        [JsonPropertyName("fraud_query_request_no")]
        public string FraudQueryRequestNo { get; set; }

        /// <summary>
        /// 案件欺诈结果，枚举值如下  FRAUD:欺诈  NON_FRAUD:非欺诈
        /// </summary>
        [JsonPropertyName("fraud_result")]
        public string FraudResult { get; set; }

        /// <summary>
        /// 报案号
        /// </summary>
        [JsonPropertyName("report_no")]
        public string ReportNo { get; set; }

        /// <summary>
        /// 请求号，每次请求需唯一
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 同步类型，新增或修改，目前只允许修改一次    NEW:新增  MODIFY:修改
        /// </summary>
        [JsonPropertyName("syn_type")]
        public string SynType { get; set; }
    }
}
