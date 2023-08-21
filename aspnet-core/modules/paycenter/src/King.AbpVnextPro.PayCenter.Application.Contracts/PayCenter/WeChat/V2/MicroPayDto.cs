using King.AbpVnextPro.Paylink.WeChat.V2.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V2
{
    public class MicroPayDto : EntityDto
    {
        public WeChatPayMicroPayResponse WeChatPayMicroPayResponse { get; set; }

        public MicroPayDto()
        {
            WeChatPayMicroPayResponse = new WeChatPayMicroPayResponse();
        }
    }
}
