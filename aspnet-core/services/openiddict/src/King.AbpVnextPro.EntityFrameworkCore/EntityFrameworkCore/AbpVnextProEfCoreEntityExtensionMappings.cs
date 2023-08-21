using King.AbpVnextPro.Institution.Departments;
using King.AbpVnextPro.Institution.Users;
using King.AbpVnextPro.Migrations;
using King.AbpVnextPro.Openiddict.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;
using Volo.Abp.Users.EntityFrameworkCore;

namespace King.AbpVnextPro.EntityFrameworkCore;

public static class AbpVnextProEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        AbpVnextProGlobalFeatureConfigurator.Configure();
        AbpVnextProModuleExtensionConfigurator.Configure();
        
        OneTimeRunner.Run(() =>
        {
            /* You can configure extra properties for the
             * entities defined in the modules used by your application.
             *
             * This class can be used to map these extra properties to table fields in the database.
             *
             * USE THIS CLASS ONLY TO CONFIGURE EF CORE RELATED MAPPING.
             * USE AbpVnextProModuleExtensionConfigurator CLASS (in the Domain.Shared project)
             * FOR A HIGH LEVEL API TO DEFINE EXTRA PROPERTIES TO ENTITIES OF THE USED MODULES
             *
             * Example: Map a property to a table field:

                 ObjectExtensionManager.Instance
                     .MapEfCoreProperty<IdentityUser, string>(
                         "MyProperty",
                         (entityBuilder, propertyBuilder) =>
                         {
                             propertyBuilder.HasMaxLength(128);
                         }
                     );

             * See the documentation for more:
             * https://docs.abp.io/en/abp/latest/Customizing-Application-Modules-Extending-Entities
             */
            ObjectExtensionManager.Instance
           .MapEfCoreProperty<IdentityUser, string>(
               "Avatar",
               (entityBuilder, propertyBuilder) =>
               {
                   propertyBuilder.HasColumnType("text");
               }
           )
           .MapEfCoreProperty<IdentityUser, string>(
               "Introduction",
               (entityBuilder, propertyBuilder) =>
               {
                   propertyBuilder.HasMaxLength(AppUserConsts.MaxIntroductionLength);
               }
           );
          
        });
    }
}
