using King.AbpVnextPro.Paylink.Alipy.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace King.AbpVnextPro.PayCenter.PayCenter.AliPay
{
    public class TransferDto:BaseDto
    {
        public AlipayFundTransUniTransferResponse AlipayFundTransUniTransferResponse { get; set; }

        public TransferDto()
        {
            AlipayFundTransUniTransferResponse = new AlipayFundTransUniTransferResponse();
        }
    }
}
