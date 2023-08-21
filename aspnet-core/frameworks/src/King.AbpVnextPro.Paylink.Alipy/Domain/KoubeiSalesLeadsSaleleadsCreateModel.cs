﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiSalesLeadsSaleleadsCreateModel Data Structure.
    /// </summary>
    public class KoubeiSalesLeadsSaleleadsCreateModel : AlipayObject
    {
        /// <summary>
        /// 销售Leads关联的业务主体id
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 销售业务主体类型，SHOP_INFO已开店，SHOP_LEADS未开店
        /// </summary>
        [JsonPropertyName("biz_principle_type")]
        public string BizPrincipleType { get; set; }

        /// <summary>
        /// 需要给销售Leads打上的标签Code，数组
        /// </summary>
        [JsonPropertyName("leads_tags")]
        public List<string> LeadsTags { get; set; }

        /// <summary>
        /// 销售Leads类型
        /// </summary>
        [JsonPropertyName("leads_type")]
        public string LeadsType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 调用方请求id，业务请求相同时应保持一致，用于幂等
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
