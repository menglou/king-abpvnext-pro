﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceApplyResultSyncModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceApplyResultSyncModel : AlipayObject
    {
        /// <summary>
        /// 支付宝发起开票申请的id，该id具有唯一性，该字段由支付宝向税控发起申请的时候带过去，作为支付宝向税控开票申请的唯一标志
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果。  取值如下：  SUCCESS:成功;FAIL:失败
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 结果码，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果进行详细说明的结果码。  取值如下：  成功(SUCCESS),  参数不合法(PARAMETER_ILLEGAL),  商户税控设备异常(MERCHANT_TAX_DEVICE_ERROR).
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果描述，支付宝向税控商或ISV发起发票申请后，对应这笔申请的发票开具结果描述信息。
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 该字段是税控商或ISV收到支付宝开票请求后生成的申请id，由税控商或isv自己生成，该id具有唯一性  当ISV接入时是按照tax_apply_id来查询发票信息时，该字段必填。
        /// </summary>
        [JsonPropertyName("tax_apply_id")]
        public string TaxApplyId { get; set; }
    }
}
