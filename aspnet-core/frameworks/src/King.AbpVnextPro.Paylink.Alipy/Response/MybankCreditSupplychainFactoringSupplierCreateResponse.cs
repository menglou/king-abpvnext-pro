﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSupplierCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSupplierCreateResponse : AlipayResponse
    {
        /// <summary>
        /// supplierNo : 供应商编号
        /// </summary>
        [JsonPropertyName("supplier_no")]
        public string SupplierNo { get; set; }
    }
}
