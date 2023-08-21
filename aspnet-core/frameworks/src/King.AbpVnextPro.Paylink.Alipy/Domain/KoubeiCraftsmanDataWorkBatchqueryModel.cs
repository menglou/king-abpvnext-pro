﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkBatchqueryModel Data Structure.
    /// </summary>
    public class KoubeiCraftsmanDataWorkBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为   koubei.member.data.oauth.query 中的 auth_code，默认有效期24小时；ISV自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 口碑手艺人id。是创建手艺人接口koubei.craftsman.data.provider.create返回的craftsman_id，或通过查询手艺人信息接口koubei.craftsman.data.provider查询craftsman_id
        /// </summary>
        [JsonPropertyName("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 页码，大于0，最大为int的最大值
        /// </summary>
        [JsonPropertyName("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 每页的条数，大于0，最大不超过100条
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 手艺人作品id列表，全局唯一，是创建手艺人作品接口   koubei.craftsman.data.work.create 返回的 work_id,使用数组方式传值
        /// </summary>
        [JsonPropertyName("work_ids")]
        public List<string> WorkIds { get; set; }
    }
}
