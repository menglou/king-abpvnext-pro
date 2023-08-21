using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class RefundDto : EntityDto
    {
        public WeChatPayRefundDomesticRefundsResponse WeChatPayRefundDomesticRefundsResponse { get; set; }
        public RefundDto()
        {
            WeChatPayRefundDomesticRefundsResponse = new WeChatPayRefundDomesticRefundsResponse();
        }
    }
}
