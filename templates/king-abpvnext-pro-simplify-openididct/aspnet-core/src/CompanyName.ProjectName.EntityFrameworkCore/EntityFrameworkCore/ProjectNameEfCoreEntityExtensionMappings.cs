﻿using King.AbpVnextPro.Openiddict.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.Threading;

namespace CompanyName.ProjectName.EntityFrameworkCore;

public static class ProjectNameEfCoreEntityExtensionMappings
{
    private static readonly OneTimeRunner OneTimeRunner = new OneTimeRunner();

    public static void Configure()
    {
        ProjectNameGlobalFeatureConfigurator.Configure();
        ProjectNameModuleExtensionConfigurator.Configure();

        OneTimeRunner.Run(() =>
        {
            /* You can configure extra properties for the
             * entities defined in the modules used by your application.
             *
             * This class can be used to map these extra properties to table fields in the database.
             *
             * USE THIS CLASS ONLY TO CONFIGURE EF CORE RELATED MAPPING.
             * USE ProjectNameModuleExtensionConfigurator CLASS (in the Domain.Shared project)
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
