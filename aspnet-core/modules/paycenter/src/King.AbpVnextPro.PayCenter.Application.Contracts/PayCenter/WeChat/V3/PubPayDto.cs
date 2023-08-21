using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class PubPayDto:EntityDto
    {
        public WeChatPayTransactionsJsApiResponse WeChatPayTransactionsJsApiResponse { get; set; }
        public WeChatPayDictionary WeChatPayDictionary { get; set; }
        public PubPayDto()
        {
            WeChatPayTransactionsJsApiResponse = new WeChatPayTransactionsJsApiResponse();
            WeChatPayDictionary = new WeChatPayDictionary();
        }
    }
}
