using King.AbpVnextPro.Paylink.WeChat.V3.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.PayCenter.PayCenter.WeChat.V3
{
    public class PermissionsDto : EntityDto
    {
        public WeChatPayScorePermissionsResponse WeChatPayScorePermissionsResponse { get; set; }
        public PermissionsDto()
        {
            WeChatPayScorePermissionsResponse = new WeChatPayScorePermissionsResponse();
        }
    }
}
