using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class RefundDto:BaseDto
    {
        public AlipayTradeRefundResponse AlipayTradeRefundResponse { get; set; }
        public RefundDto()
        {
            AlipayTradeRefundResponse = new AlipayTradeRefundResponse();
        }
    }
}
