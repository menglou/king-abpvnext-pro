﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// LogisticsShopStatusDTO Data Structure.
    /// </summary>
    public class LogisticsShopStatusDTO : AlipayObject
    {
        /// <summary>
        /// 商家在配送公司的账户的审核说明.
        /// </summary>
        [JsonPropertyName("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 配送公司物流编码。
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 配送公司名称。
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 门店状态，AUDITING:审核中，AUDIT_REJECT:审核驳回，VALID:已生效，UPDATING:更新中，WAIT_CREATE:待开通(存量门店若需要支持后面新增的配送公司，需要调用门店更新接口发起申请)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
