using King.AbpVnextPro.IdentityServer.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace King.AbpVnextPro.IdentityServer.Features
{
    public class BasicManagementFeatureDefinitionProvider: FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var group = context.AddGroup(BasicManagementFeatures.GroupName);

            //移除调某些自带的
            context.RemoveGroup("SettingManagement");

            //允许社交登录
            group.AddFeature(BasicManagementFeatures.SocialLogins, "true", L("Feature:SocialLogins")
                , valueType: new ToggleStringValueType());

            //允许租户添加的用户不能超过多少个 默认是10个
            group.AddFeature(BasicManagementFeatures.UserCount, "10", L("Feature:UserCount")
                , valueType: new FreeTextStringValueType(new NumericValueValidator(1, 1000)));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<IdentityServerResource>(name);
        }
    }
}
