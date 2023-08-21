using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class WeChatPayV3RefundQueryViewModel
    {
        [Display(Name = "refund_id")]
        public string RefundId { get; set; }

        [Display(Name = "out_refund_no")]
        public string OutRefundNo { get; set; }

        [Display(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [Display(Name = "out_trade_no")]
        public string OutTradeNo { get; set; }
    }
}
