﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// WaybillInvoice Data Structure.
    /// </summary>
    public class WaybillInvoice : AlipayObject
    {
        /// <summary>
        /// 即时配送运单金额
        /// </summary>
        [JsonPropertyName("waybill_amount")]
        public string WaybillAmount { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [JsonPropertyName("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
