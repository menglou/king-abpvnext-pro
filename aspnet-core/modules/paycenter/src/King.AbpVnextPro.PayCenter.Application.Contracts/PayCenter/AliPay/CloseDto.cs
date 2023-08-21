using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class CloseDto:BaseDto
    {
        public AlipayTradeCloseResponse AlipayTradeCloseResponse { get; set; }  

        public CloseDto()
        {
            AlipayTradeCloseResponse = new AlipayTradeCloseResponse();
        }
    }
}
