﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBusinessPaymenthubDisburseModel Data Structure.
    /// </summary>
    public class AlipayBusinessPaymenthubDisburseModel : AlipayObject
    {
        /// <summary>
        /// 打款金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [JsonPropertyName("disburse_amount")]
        public string DisburseAmount { get; set; }

        /// <summary>
        /// 打款请求号，对应一笔业务订单下的一次打款请求，不同打款请求需保证请求号唯一
        /// </summary>
        [JsonPropertyName("disburse_request_no")]
        public string DisburseRequestNo { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonPropertyName("payee")]
        public UserIdentity Payee { get; set; }

        /// <summary>
        /// 收款方的额外信息，包含会员信息和支付机构账号信息
        /// </summary>
        [JsonPropertyName("payee_ext")]
        public UserIdentityExt PayeeExt { get; set; }

        /// <summary>
        /// 支付id，支付宝针对每一笔支付请求生成的唯一支付凭证
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId { get; set; }

        /// <summary>
        /// 打款说明
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
