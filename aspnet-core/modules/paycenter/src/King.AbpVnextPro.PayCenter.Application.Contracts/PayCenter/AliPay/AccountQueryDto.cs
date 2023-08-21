using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class AccountQueryDto:BaseDto
    {
        public AlipayFundAccountQueryResponse AlipayFundAccountQueryResponse { get; set; }
        public AccountQueryDto()
        {
            AlipayFundAccountQueryResponse = new AlipayFundAccountQueryResponse();
        }
    }
}
