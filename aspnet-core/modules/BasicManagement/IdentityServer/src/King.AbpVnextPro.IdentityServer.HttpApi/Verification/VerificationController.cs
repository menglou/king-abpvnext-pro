
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace King.AbpVnextPro.IdentityServer.Verification
{
    [RemoteService(Name = "Verification")]
    [ControllerName("Verification")]
    [Route("api/verification")]
    public class VerificationController : IdentityServerController, IVerificationAppService
    {
        protected IVerificationAppService _verificationAppService;

        protected IConfiguration _config;
        public VerificationController(IVerificationAppService verificationAppService, IConfiguration config)
        {
            this._verificationAppService = verificationAppService;
            _config = config;
        }

        [HttpGet]
        [Route("verification-code")]
        public virtual VerifyCode GetVerificationCode()
        {
            var veryCode = _verificationAppService.GetVerificationCode();
            //验证码统一转成小写MD5
            HttpContext.Response.Cookies.Append("verycode", Md5(veryCode.Code.ToLower()), new CookieOptions()
            {
                Expires = DateTime.Now.AddMinutes(5),
                SameSite = SameSiteMode.None,
                IsEssential = true
            });
            // return File(veryCode.Image, @"image/jpeg");
            return veryCode;
        }
        [HttpGet]
        [Route("vertifyveriCode/{id}/{code}")]
        public virtual Task<string> GetVerifyCodeMd5FromCache(string id, string code)
        {
            return _verificationAppService.GetVerifyCodeMd5FromCache(id, code);
        }

        private string Md5(string str)
        {
            //将字符串编码为字节序列
            byte[] bt = Encoding.UTF8.GetBytes(str);
            //创建默认实现的实例
            var md5 = MD5.Create();
            //计算指定字节数组的哈希值。
            var md5bt = md5.ComputeHash(bt);
            //将byte数组转换为字符串
            StringBuilder builder = new StringBuilder();
            foreach (var item in md5bt)
            {
                builder.Append(item.ToString("X2"));
            }
            string md5Str = builder.ToString();
            return builder.ToString();
        }
    }
}
