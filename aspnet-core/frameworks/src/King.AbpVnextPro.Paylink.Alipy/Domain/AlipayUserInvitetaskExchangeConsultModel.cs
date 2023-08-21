﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConsultModel Data Structure.
    /// </summary>
    public class AlipayUserInvitetaskExchangeConsultModel : AlipayObject
    {
        /// <summary>
        /// 猫超券兑换金额,单位:分
        /// </summary>
        [JsonPropertyName("exchange_amount_money")]
        public long ExchangeAmountMoney { get; set; }

        /// <summary>
        /// 兑换类型：PRODUCT/实物商品；TMALL_COUPON/猫超券
        /// </summary>
        [JsonPropertyName("exchange_type")]
        public string ExchangeType { get; set; }

        /// <summary>
        /// 比如某种业务标准外部订单号,比如交易外部订单号，代表商户端自己订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 兑换商品ID
        /// </summary>
        [JsonPropertyName("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 邀请任务进程业务号
        /// </summary>
        [JsonPropertyName("task_process_id")]
        public string TaskProcessId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
