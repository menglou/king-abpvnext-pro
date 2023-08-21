using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.ObjectExtending.Modularity;

namespace King.AbpVnextPro.Institution
{
    public class InstitutionModuleExtensionConfiguration : ModuleExtensionConfiguration
    {
        public InstitutionModuleExtensionConfiguration ConfigureDepartmentUnit(
       Action<EntityExtensionConfiguration> configureAction)
        {
            return this.ConfigureEntity(
                "DepartmentUnit",
                configureAction
            );
        }
    }
}
