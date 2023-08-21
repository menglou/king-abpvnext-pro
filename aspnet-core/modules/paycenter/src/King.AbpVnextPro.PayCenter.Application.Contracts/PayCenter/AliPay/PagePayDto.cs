using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class PagePayDto:EntityDto
    {
        public AlipayTradePagePayResponse AlipayTradePagePayResponse { get; set; }
        public PagePayDto()
        {
            AlipayTradePagePayResponse = new AlipayTradePagePayResponse();
        }
    }
}
