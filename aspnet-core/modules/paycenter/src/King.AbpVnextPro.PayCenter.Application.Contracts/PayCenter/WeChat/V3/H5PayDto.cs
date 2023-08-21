using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class H5PayDto : EntityDto
    {
        public WeChatPayTransactionsH5Response WeChatPayTransactionsH5Response { get; set; }
        public H5PayDto()
        {
            WeChatPayTransactionsH5Response = new WeChatPayTransactionsH5Response();
        }
    }
}
