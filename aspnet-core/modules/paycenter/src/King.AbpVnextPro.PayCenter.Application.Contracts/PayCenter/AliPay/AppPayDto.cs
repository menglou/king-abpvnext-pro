using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class AppPayDto:EntityDto
    {
        public AlipayTradeAppPayResponse AlipayTradeAppPayResponse { get; set; }
        public AppPayDto()
        {
            AlipayTradeAppPayResponse = new AlipayTradeAppPayResponse();
        }
    }
}
