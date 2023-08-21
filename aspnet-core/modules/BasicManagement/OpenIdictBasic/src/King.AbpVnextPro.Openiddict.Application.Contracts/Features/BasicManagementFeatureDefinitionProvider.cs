using King.AbpVnextPro.Openiddict.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace King.AbpVnextPro.Openiddict.Features
{
   public class BasicManagementFeatureDefinitionProvider: FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var group = context.AddGroup(BasicManagementFeatures.GroupName);

            //移除调某些自带的
            context.RemoveGroup("SettingManagement");

            group.AddFeature(BasicManagementFeatures.SocialLogins, "true", L("Feature:SocialLogins")
                , valueType: new ToggleStringValueType());
            group.AddFeature(BasicManagementFeatures.UserCount, "10", L("Feature:UserCount")
                , valueType: new FreeTextStringValueType(new NumericValueValidator(1, 1000)));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OpeniddictResource>(name);
        }
    }
}
