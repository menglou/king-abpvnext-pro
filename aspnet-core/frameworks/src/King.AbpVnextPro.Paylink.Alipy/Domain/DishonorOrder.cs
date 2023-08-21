﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// DishonorOrder Data Structure.
    /// </summary>
    public class DishonorOrder : AlipayObject
    {
        /// <summary>
        /// 退票金额：单位：元。  只支持2位小数，小数点前最大支持13位，金额必须大于0。
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 退票时间：格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonPropertyName("dishonor_date")]
        public string DishonorDate { get; set; }

        /// <summary>
        /// 退票原因：银行返回的退票原因。
        /// </summary>
        [JsonPropertyName("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 支付宝转账单据号。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户转账唯一订单号:发起转账来源方定义的转账单据号。该参数的赋值均以查询结果中的out_biz_no为准。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付时间:格式为yyyy-MM-dd HH:mm:ss。转账失败不返回。
        /// </summary>
        [JsonPropertyName("pay_date")]
        public string PayDate { get; set; }

        /// <summary>
        /// 付款方账户:付款方支付宝唯一标识（2088开头16位数字字符串）或支付宝会员登录号（邮箱或手机号）
        /// </summary>
        [JsonPropertyName("payer_account")]
        public string PayerAccount { get; set; }

        /// <summary>
        /// 提现流水号。
        /// </summary>
        [JsonPropertyName("payment_no")]
        public string PaymentNo { get; set; }
    }
}
