using King.AbpVnextPro.Paylink.WeChat;
using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class AppPayDto:EntityDto
    {
        public WeChatPayTransactionsAppResponse WeChatPayTransactionsAppResponse { get; set; }  
        public WeChatPayDictionary WeChatPayDictionary { get; set; }
        public AppPayDto () {

            WeChatPayTransactionsAppResponse = new WeChatPayTransactionsAppResponse();
            WeChatPayDictionary = new WeChatPayDictionary();
        } 
    }
}
