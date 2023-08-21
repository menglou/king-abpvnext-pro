using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class PreCreateDto:EntityDto
    {
        public AlipayTradePrecreateResponse AlipayTradePrecreateResponse { get; set; }
        public PreCreateDto()
        {
            AlipayTradePrecreateResponse = new AlipayTradePrecreateResponse();
        }
    }
}
