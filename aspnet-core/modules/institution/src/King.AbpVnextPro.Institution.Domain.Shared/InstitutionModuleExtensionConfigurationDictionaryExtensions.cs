using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.ObjectExtending.Modularity;

namespace King.AbpVnextPro.Institution
{
    public static class InstitutionModuleExtensionConfigurationDictionaryExtensions
    {
        public static ModuleExtensionConfigurationDictionary ConfigureInstitution(
        this ModuleExtensionConfigurationDictionary modules,
        Action<InstitutionModuleExtensionConfiguration> configureAction)
        {
            return modules.ConfigureModule(
                "Institution",
                configureAction
            );
        }
    }
}
