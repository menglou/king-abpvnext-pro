﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayAssetPointPointprodBudgetlibModifyResponse.
    /// </summary>
    public class AlipayAssetPointPointprodBudgetlibModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 预算库有效期修改失败时的错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
