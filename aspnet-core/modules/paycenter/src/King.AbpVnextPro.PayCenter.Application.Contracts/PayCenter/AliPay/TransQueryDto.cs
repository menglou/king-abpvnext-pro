using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class TransQueryDto:BaseDto
    {
        public AlipayFundTransCommonQueryResponse AlipayFundTransCommonQueryResponse { get; set; }
        public TransQueryDto()
        {
            AlipayFundTransCommonQueryResponse = new AlipayFundTransCommonQueryResponse();
        }
    }
}
