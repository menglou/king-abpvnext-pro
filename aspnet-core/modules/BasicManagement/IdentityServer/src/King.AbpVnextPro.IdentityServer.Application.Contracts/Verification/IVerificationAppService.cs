using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace King.AbpVnextPro.IdentityServer.Verification
{
   public interface IVerificationAppService:IApplicationService
    {
        VerifyCode GetVerificationCode();

        Task<string> GetVerifyCodeMd5FromCache(string Id,string code);
    }
}
