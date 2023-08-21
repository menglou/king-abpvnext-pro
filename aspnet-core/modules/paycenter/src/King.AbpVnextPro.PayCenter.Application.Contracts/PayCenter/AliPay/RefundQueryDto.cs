using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class RefundQueryDto:BaseDto
    {
        public AlipayTradeFastpayRefundQueryResponse AlipayTradeFastpayRefundQueryResponse { get; set; }

        public RefundQueryDto()
        {
            AlipayTradeFastpayRefundQueryResponse = new AlipayTradeFastpayRefundQueryResponse();
        }
    }
}
