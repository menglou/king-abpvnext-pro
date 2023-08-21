using King.AbpVnextPro.Paylink.WeChat.V2.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V2
{
    public class OrderQueryDto:EntityDto
    {
        public WeChatPayOrderQueryResponse WeChatPayOrderQueryResponse { get; set; }    

        public OrderQueryDto()
        {
            WeChatPayOrderQueryResponse=new WeChatPayOrderQueryResponse();  
        }
    }
}
