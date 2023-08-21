﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailWmsSupplierreportdetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [JsonPropertyName("supplier_report_id")]
        public string SupplierReportId { get; set; }
    }
}
