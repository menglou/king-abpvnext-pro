using IdentityServer4.AspNetIdentity;
using IdentityServer4.Models;
using IdentityServer4.Validation;
using King.AbpVnextPro.IdentityServer.Verification;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer.AspNetIdentity;
using Volo.Abp.IdentityServer.Localization;
using Volo.Abp.Uow;
using IdentityUser = Volo.Abp.Identity.IdentityUser;


namespace CompanyName.ProjectName
{
    public class VerifyGrantValidator : AbpResourceOwnerPasswordValidator
    {
        private IVerificationAppService verificationAppService { get; set; }
        public VerifyGrantValidator(UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager,
        IdentitySecurityLogManager identitySecurityLogManager,
        ILogger<ResourceOwnerPasswordValidator<IdentityUser>> logger,
        IStringLocalizer<AbpIdentityServerResource> localizer,
        IOptions<AbpIdentityOptions> abpIdentityOptions,
        IHybridServiceScopeFactory serviceScopeFactory,
        IOptions<IdentityOptions> identityOptions, IVerificationAppService _verificationAppService) : base(userManager, signInManager, identitySecurityLogManager, logger, localizer, abpIdentityOptions, serviceScopeFactory, identityOptions)
        {
            verificationAppService = _verificationAppService;
        }

        [UnitOfWork]
        public override async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            //判断是否需要验证码登录
            //验证验证码无效
            bool isneedvertifycode = Convert.ToBoolean(context.Request.Raw["isneedvertifycode"]);
            if (isneedvertifycode == true)
            {
                string vertifycode = context.Request.Raw["vericode"];
                string vertifyId = context.Request.Raw["vericodeId"];

                string result = await verificationAppService.GetVerifyCodeMd5FromCache(vertifyId, vertifycode);

                if (result == "SUCCESS")
                {
                    await base.ValidateAsync(context);
                }
                else
                {
                    context.Result = new GrantValidationResult(TokenRequestErrors.InvalidGrant, result);
                }
            }
            else
            {
                await base.ValidateAsync(context);
            }
        }
    }
}
