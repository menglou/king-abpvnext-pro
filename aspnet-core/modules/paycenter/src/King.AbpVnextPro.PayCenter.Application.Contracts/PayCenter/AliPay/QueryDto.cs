using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class QueryDto: BaseDto
    {
        public AlipayTradeQueryResponse AlipayTradeQueryResponse { get; set; }
        public QueryDto()
        {
            AlipayTradeQueryResponse = new AlipayTradeQueryResponse();
        }
    }
}
