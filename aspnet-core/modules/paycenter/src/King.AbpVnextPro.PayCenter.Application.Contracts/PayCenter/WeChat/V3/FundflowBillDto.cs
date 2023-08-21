using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class FundflowBillDto : EntityDto
    {
        public WeChatPayBillFundflowBillResponse WeChatPayBillFundflowBillResponse { get; set; }
        public FundflowBillDto()
        {
            WeChatPayBillFundflowBillResponse = new WeChatPayBillFundflowBillResponse();
        }
    }
}
