using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class PayDto:EntityDto
    {
        public AlipayTradePayResponse AlipayTradePayResponse { get; set; }

        public PayDto()
        {
            AlipayTradePayResponse = new AlipayTradePayResponse();
        }
    }
}
