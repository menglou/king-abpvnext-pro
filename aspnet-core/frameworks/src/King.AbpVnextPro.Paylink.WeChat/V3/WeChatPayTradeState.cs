﻿namespace King.AbpVnextPro.Paylink.WeChat.V3
{
    /// <summary>
    /// 交易状态
    /// </summary>
    public static class WeChatPayTradeState
    {
        /// <summary>
        /// 支付成功
        /// </summary>
        public const string Success = "SUCCESS";

        /// <summary>
        /// 转入退款
        /// </summary>
        public const string Refund = "REFUND";

        /// <summary>
        /// 未支付
        /// </summary>
        public const string NotPay = "NOTPAY";

        /// <summary>
        /// 已关闭
        /// </summary>
        public const string Closed = "CLOSED";

        /// <summary>
        /// 已撤销（付款码支付）
        /// </summary>
        public const string Revoked = "REVOKED";

        /// <summary>
        /// 用户支付中（付款码支付）
        /// </summary>
        public const string UserPaying = "USERPAYING";

        /// <summary>
        /// 支付失败(其他原因，如银行返回失败)
        /// </summary>
        public const string PayError = "PAYERROR";

        /// <summary>
        /// 已接收，等待扣款
        /// </summary>
        public const string Accept = "ACCEPT";
    }
}
