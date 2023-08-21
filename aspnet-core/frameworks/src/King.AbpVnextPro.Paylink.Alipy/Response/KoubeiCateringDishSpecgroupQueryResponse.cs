﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiCateringDishSpecgroupQueryResponse.
    /// </summary>
    public class KoubeiCateringDishSpecgroupQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户的在接入蚂蚁开放平台的user_id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 规格标签信息
        /// </summary>
        [JsonPropertyName("spec_group_list")]
        public List<KbdishSpecGroup> SpecGroupList { get; set; }
    }
}
