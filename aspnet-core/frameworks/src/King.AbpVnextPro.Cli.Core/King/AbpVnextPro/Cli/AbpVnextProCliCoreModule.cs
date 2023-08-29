
using Microsoft.Extensions.DependencyInjection;

namespace King.AbpVnextPro.Cli;

[DependsOn(
    typeof(AbpDddDomainModule)
)]
public class AbpVnextProCliCoreModule: AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpCliOptions>(options => { options.Commands[HelpCommand.Name] = typeof(HelpCommand); });
        Configure<AbpCliOptions>(options => { options.Commands[NewCommand.Name] = typeof(NewCommand); });

        Configure<Options.AbpVnextProCliOptions>(options =>
        {
            options.Owner = "menglou";
            options.GiteeOwner = "zljlm";
            options.RepositoryId = "king-abpvnext-pro";
            options.Token = "king-abp-vnext-proghp_VoZ695yqcy9gIvBISEwsking-abp-vnext-proYEbSyuOK8w3ihAEb";
            options.Templates = new List<AbpProTemplateOptions>()
            {
                new AbpProTemplateOptions("king-abp-vnext-pro", "pro", "源码版本", true)
                {
                    ExcludeFiles = "templates,docs,.github,LICENSE,Readme.md",
                    ReplaceSuffix = ".sln,.csproj,.cs,.cshtml,.json,.ci,.yml,.yaml,.nswag,.DotSettings,.env,Directory.Build.King.targets",
                    OldCompanyName = "King",
                    OldProjectName = "AbpVnextPro"
                },
                new AbpProTemplateOptions("king-abp-vnext-pro-nuget-identityserver4-all", "pro.id4.all", "Nuget完整版本(鉴权IdentityServer4)")
                {
                    //ExcludeFiles = "aspnet-core,vben28,abp-vnext-pro-nuget-module,abp-vnext-pro-nuget-simplify,docs,.github,LICENSE,Readme.md",
                    ReplaceSuffix = ".sln,.csproj,.cs,.cshtml,.json,.ci,.yml,.yaml,.nswag,.DotSettings,.env,Directory.Build.King.targets",
                    OldCompanyName = "CompanyName",
                    OldProjectName = "ProjectName"
                },
                 new AbpProTemplateOptions("king-abp-vnext-pro-nuget-openiddict-all", "pro.openiddict.all", "Nuget完整版本(鉴权OpenIddict)")
                {
                    //ExcludeFiles = "aspnet-core,vben28,abp-vnext-pro-nuget-module,abp-vnext-pro-nuget-simplify,docs,.github,LICENSE,Readme.md",
                    ReplaceSuffix = ".sln,.csproj,.cs,.cshtml,.json,.ci,.yml,.yaml,.nswag,.DotSettings,.env,Directory.Build.King.targets",
                    OldCompanyName = "CompanyName",
                    OldProjectName = "ProjectName"
                },
                new AbpProTemplateOptions("king-abp-vnext-pro-nuget-simplify", "pro.simplify", "Nuget简单版本(没有工作流)")
                {
                    //ExcludeFiles = "aspnet-core,vben28,abp-vnext-pro-nuget-module,abp-vnext-pro-nuget-all,docs,.github,LICENSE,Readme.md",
                    ReplaceSuffix = ".sln,.csproj,.cs,.cshtml,.json,.ci,.yml,.yaml,.nswag,.DotSettings,.env,Directory.Build.Lion.targets",
                    OldCompanyName = "CompanyName",
                    OldProjectName = "ProjectName"
                },
                //new AbpProTemplateOptions("king-abp-vnext-pro-nuget-module", "pro.module", "模块")
                //{
                //    //ExcludeFiles = "aspnet-core,vben28,abp-vnext-pro-nuget-all,abp-vnext-pro-nuget-simplify,docs,.github,LICENSE,Readme.md",
                //    ReplaceSuffix = ".sln,.csproj,.cs,.cshtml,.json,.ci,.yml,.yaml,.nswag,.DotSettings,.env,Directory.Build.Lion.targets",
                //    OldCompanyName = "MyCompanyName",
                //    OldProjectName = "MyProjectName",
                //    OldModuleName = "MyModuleName",
                //},
            };
        });

        context.Services.AddHttpClient();
    }
}