﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// KoubeiMerchantDepartmentModifyResponse.
    /// </summary>
    public class KoubeiMerchantDepartmentModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 修改商户部门成功时返回的部门id
        /// </summary>
        [JsonPropertyName("dept_id")]
        public string DeptId { get; set; }
    }
}
