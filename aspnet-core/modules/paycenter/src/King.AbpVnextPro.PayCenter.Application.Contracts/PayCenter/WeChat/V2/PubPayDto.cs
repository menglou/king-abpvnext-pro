using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V2;
using King.AbpVnextPro.Paylink.WeChat.V2.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V2
{
    public class PubPayDto : EntityDto
    {
        public WeChatPayUnifiedOrderResponse WeChatPayUnifiedOrderResponse { get; set; }

        public WeChatPayDictionary WeChatPayDictionary { get; set; }

        public PubPayDto()
        {
            WeChatPayUnifiedOrderResponse = new WeChatPayUnifiedOrderResponse();
            WeChatPayDictionary = new WeChatPayDictionary();
        }
    }
}
