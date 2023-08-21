using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class BillDownloadDto:EntityDto
    {
        public WeChatPayBillDownloadResponse WeChatPayBillDownloadResponse { get; set; }
        public BillDownloadDto()
        {
            WeChatPayBillDownloadResponse = new WeChatPayBillDownloadResponse();
        }
    }
}
