
namespace King.AbpVnextPro.Cli.Utils;
public static class ReplacePackageReferenceExtensions
{
    public static string ReplacePackageReferenceCore(this string content)
    {
        return content
                //替换掉 King.AbpVnextPro.Core 基础模块引用的
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\frameworks\\src\\King.AbpVnextPro.Core\\King.AbpVnextPro.Core.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Core\" />")

                //替换支付宝
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\aspnet-core\\frameworks\\src\\King.AbpVnextPro.Paylink.Alipy\\King.AbpVnextPro.Paylink.Alipy.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Paylink.Alipy\" />")

                //替换微信 
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\aspnet-core\\frameworks\\src\\King.AbpVnextPro.Paylink.WeChat\\King.AbpVnextPro.Core.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Paylink.WeChat\" />")


                 //有可能这种情况 比如不是基础module 引用的 因为两个基础模块外面有多了个文件夹，所以相对会多一层
                 .Replace("<ProjectReference Include=\"..\\..\\..\\..\\aspnet-core\\frameworks\\src\\King.AbpVnextPro.Core\\King.AbpVnextPro.Core.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Core\" />")


                //移除网关模块
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\shared\\King.AbpVnextPro.Shared.Hosting.Microservices\\King.AbpVnextPro.Shared.Hosting.Microservices.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Shared.Hosting.Microservices\" />")
                //移除网关模块
                .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\shared\\King.AbpVnextPro.Shared.Hosting.Gateways\\King.AbpVnextPro.Shared.Hosting.Gateways.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Shared.Hosting.Gateways\" />")

                //替换掉 计划模块中引用 notice 模块的
                 .Replace("<ProjectReference Include=\"..\\..\\..\\Notification\\src\\King.AbpVnextPro.Notice.Application\\King.AbpVnextPro.Notice.Application.csproj\" />",
                    "<PackageReference Include=\"Kings.AbpVnextPro.Notice.Application.csproj\" />")
            ;
    }

    public static string ReplacePackageReferenceBasicManagement(this string content)
    {
        return content
            //identityserver 模板的
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.Application\\King.AbpVnextPro.IdentityServer.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.Application\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.Application.Contracts\\King.AbpVnextPro.IdentityServer.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.Application.Contracts\" />")

            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.Domain\\King.AbpVnextPro.IdentityServer.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.Domain\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.Domain.Shared\\King.AbpVnextPro.IdentityServer.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.Domain.Shared\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.EntityFrameworkCore\\King.AbpVnextPro.IdentityServer.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.EntityFrameworkCore\"/>")

         
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.HttpApi\\King.AbpVnextPro.IdentityServer.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.HttpApi\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\IdentityServer\\src\\King.AbpVnextPro.IdentityServer.HttpApi.Client\\King.AbpVnextPro.IdentityServer.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.IdentityServer.HttpApi.Client\" />")

           //openiddict
          .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.Application\\King.AbpVnextPro.Openiddict.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.Application\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.Application.Contracts\\King.AbpVnextPro.Openiddict.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.Application.Contracts\"/>")

            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.Domain\\King.AbpVnextPro.Openiddict.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.Domain\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.Domain.Shared\\King.AbpVnextPro.Openiddict.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.Domain.Shared\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.EntityFrameworkCore\\King.AbpVnextPro.Openiddict.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.EntityFrameworkCore\"/>")


            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.HttpApi\\King.AbpVnextPro.Openiddict.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.HttpApi\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\BasicManagement\\OpenIdictBasic\\src\\King.AbpVnextPro.Openiddict.HttpApi.Client\\King.AbpVnextPro.Openiddict.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Openiddict.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceDataDictionaryManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.Application\\King.AbpVnextPro.Dictionary.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.Application.Contracts\\King.AbpVnextPro.Dictionary.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.Application.Contracts\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.Domain\\King.AbpVnextPro.Dictionary.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.Domain.Shared\\King.AbpVnextPro.Dictionary.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.EntityFrameworkCore\\King.AbpVnextPro.Dictionary.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.EntityFrameworkCore\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.HttpApi\\King.AbpVnextPro.Dictionary.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\dictionary\\src\\King.AbpVnextPro.Dictionary.HttpApi.Client\\King.AbpVnextPro.Dictionary.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Dictionary.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceFileManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.Application\\King.AbpVnextPro.File.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.Application.Contracts\\King.AbpVnextPro.File.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.Application.Contracts\"/>")
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.Domain\\King.AbpVnextPro.File.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.Domain.Shared\\King.AbpVnextPro.File.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.EntityFrameworkCore\\King.AbpVnextPro.File.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.EntityFrameworkCore\"/>")
          
            .Replace("<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.HttpApi\\King.AbpVnextPro.File.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\filemanagement\\src\\King.AbpVnextPro.File.HttpApi.Client\\King.AbpVnextPro.File.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.File.HttpApi.Client\"/>");
    }

    public static string ReplacePackageReferenceNotificationManagement(this string content)
    {
        return content

            //identityserver4
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.Application\\King.AbpVnextPro.Notice.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.Application.Contracts\\King.AbpVnextPro.Notice.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.Application.Contracts\" />")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.Domain\\King.AbpVnextPro.Notice.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.Domain.Shared\\King.AbpVnextPro.Notice.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.EntityFrameworkCore\\King.AbpVnextPro.Notice.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.EntityFrameworkCore\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.HttpApi\\King.AbpVnextPro.Notice.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\Notification\\src\\King.AbpVnextPro.Notice.HttpApi.Client\\King.AbpVnextPro.Notice.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Notice.HttpApi.Client\"/>");

           
    }

    public static string ReplacePackageReferenceScheduleTaskManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.Application\\King.AbpVnextPro.ScheduleTask.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.Application.Contracts\\King.AbpVnextPro.ScheduleTask.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.Application.Contracts\" />")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.Domain\\King.AbpVnextPro.ScheduleTask.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.Domain.Shared\\King.AbpVnextPro.ScheduleTask.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.EntityFrameworkCore\\King.AbpVnextPro.ScheduleTask.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.EntityFrameworkCore\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.HttpApi\\King.AbpVnextPro.ScheduleTask.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\scheduletask\\src\\King.AbpVnextPro.ScheduleTask.HttpApi.Client\\King.AbpVnextPro.ScheduleTask.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.ScheduleTask.HttpApi.Client\"/>");

    }

    public static string ReplacePackageReferencePayCenterManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.Application\\King.AbpVnextPro.PayCenter.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.Application.Contracts\\King.AbpVnextPro.PayCenter.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.Application.Contracts\" />")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.Domain\\King.AbpVnextPro.PayCenter.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.Domain.Shared\\King.AbpVnextPro.PayCenter.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.EntityFrameworkCore\\King.AbpVnextPro.PayCenter.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.EntityFrameworkCore\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.HttpApi\\King.AbpVnextPro.PayCenter.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\paycenter\\src\\King.AbpVnextPro.PayCenter.HttpApi.Client\\King.AbpVnextPro.PayCenter.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.PayCenter.HttpApi.Client\"/>");

    }

    public static string ReplacePackageReferenceInstitutionManagement(this string content)
    {
        return content
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.Application\\King.AbpVnextPro.Institution.Application.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.Application\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.Application.Contracts\\King.AbpVnextPro.Institution.Application.Contracts.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.Application.Contracts\" />")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.Domain\\King.AbpVnextPro.Institution.Domain.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.Domain\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.Domain.Shared\\King.AbpVnextPro.Institution.Domain.Shared.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.Domain.Shared\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.EntityFrameworkCore\\King.AbpVnextPro.Institution.EntityFrameworkCore.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.EntityFrameworkCore\"/>")

            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.HttpApi\\King.AbpVnextPro.Institution.HttpApi.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.HttpApi\"/>")
            .Replace(
                "<ProjectReference Include=\"..\\..\\..\\..\\..\\aspnet-core\\modules\\institution\\src\\King.AbpVnextPro.Institution.HttpApi.Client\\King.AbpVnextPro.Institution.HttpApi.Client.csproj\" />",
                "<PackageReference Include=\"Kings.AbpVnextPro.Institution.HttpApi.Client\"/>");

    }

    public static string ReplaceKingPackageVersion(this string context, string version)
    {
        return context.Replace("MyVersion", version);
    }
}
