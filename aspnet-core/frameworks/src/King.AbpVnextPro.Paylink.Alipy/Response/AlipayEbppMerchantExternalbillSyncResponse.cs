﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillSyncResponse.
    /// </summary>
    public class AlipayEbppMerchantExternalbillSyncResponse : AlipayResponse
    {
        /// <summary>
        /// yyyyMMdd+0(DB_FLAG)+0070(SYSTEM_FLAG)+018(SUB_BIZ_FLAG,新建)+0000(预留)+DB_SPLIT(BIZ_TYPE+SUB_BIZTYPE+MERCHANT_CODE, 2位)+TABLE_FLAG(OBJECT_ID, 2位)+8位全局唯一nextValue
        /// </summary>
        [JsonPropertyName("alipay_bill_id")]
        public string AlipayBillId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// WAIT_PAY/FINISH_PAY/REFUND
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
