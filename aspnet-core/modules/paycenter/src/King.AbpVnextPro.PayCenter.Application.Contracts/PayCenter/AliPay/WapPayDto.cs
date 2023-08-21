using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class WapPayDto:EntityDto
    {
        public AlipayTradeWapPayResponse AlipayTradeWapPayResponse { get; set; }
        public WapPayDto()
        {
            AlipayTradeWapPayResponse = new AlipayTradeWapPayResponse();
        }
    }
}
