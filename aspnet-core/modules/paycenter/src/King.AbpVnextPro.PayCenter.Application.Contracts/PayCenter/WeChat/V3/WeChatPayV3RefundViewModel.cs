using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class WeChatPayV3RefundViewModel
    {
        [Required]
        [Display(Name = "out_refund_no")]
        public string OutRefundNo { get; set; }

        [Display(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }

        [Display(Name = "notify_url")]
        public string NotifyUrl { get; set; }

        [Required]
        [Display(Name = "amount.refund")]
        public int RefundAmount { get; set; }

        [Required]
        [Display(Name = "amount.total")]
        public int TotalAmount { get; set; }

        [Required]
        [Display(Name = "currency")]
        public string Currency { get; set; }
    }
}
