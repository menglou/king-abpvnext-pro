using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace King.AbpVnextPro.IdentityServer.Logs
{
    public class MessageModelDto: EntityDto
    {
        public string Message { get; set; }
        public bool IsSuccesss { get; set; }
    }
}
