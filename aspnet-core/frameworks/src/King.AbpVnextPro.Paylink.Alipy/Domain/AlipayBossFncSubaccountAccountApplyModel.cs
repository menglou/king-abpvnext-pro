﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncSubaccountAccountApplyModel Data Structure.
    /// </summary>
    public class AlipayBossFncSubaccountAccountApplyModel : AlipayObject
    {
        /// <summary>
        /// 子户创建申请
        /// </summary>
        [JsonPropertyName("apply_sub_account_and_bind_order")]
        public ApplySubAccountAndBindOrder ApplySubAccountAndBindOrder { get; set; }
    }
}
