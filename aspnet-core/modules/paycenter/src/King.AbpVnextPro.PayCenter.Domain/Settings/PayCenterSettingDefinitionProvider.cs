using King.AbpVnextPro.PayCenter.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace King.AbpVnextPro.PayCenter.Settings;

public class PayCenterSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        /* Define module settings here.
         * Use names from PayCenterSettings class.
         */
        context.Add(
                   //微信的配置信息
                    new SettingDefinition(
                    PayCenterSettings.WechatAppId,
                    "",
                    L("DisplayName:PayCenter.Wechat.AppId"),
                    L("DisplayName:PayCenter.Wechat.AppId.DESC")
                    )
                        .WithProperty("Group1", "PayCenter")
                        .WithProperty("Group2", "Wechat")
                        .WithProperty("Type", "text"),


                     new SettingDefinition(
                       PayCenterSettings.WechatAppSecretId,
                       "",
                       L("DisplayName:PayCenter.Wechat.AppSecret"),
                       L("DisplayName:PayCenter.Wechat.AppSecret.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),


                     new SettingDefinition(
                       PayCenterSettings.MchId,
                       "",
                       L("DisplayName:PayCenter.Wechat.MchId"),
                       L("DisplayName:PayCenter.Wechat.MchId.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),

                    new SettingDefinition(
                       PayCenterSettings.SubAppId,
                       "",
                       L("DisplayName:PayCenter.Wechat.SubAppId"),
                       L("DisplayName:PayCenter.Wechat.SubAppId.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),

                    new SettingDefinition(
                       PayCenterSettings.SubMchId,
                       "",
                       L("DisplayName:PayCenter.Wechat.SubMchId"),
                       L("DisplayName:PayCenter.Wechat.SubMchId.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),


                     new SettingDefinition(
                       PayCenterSettings.APIKey,
                       "",
                       L("DisplayName:PayCenter.Wechat.APIKey"),
                       L("DisplayName:PayCenter.Wechat.APIKey.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),

                     new SettingDefinition(
                       PayCenterSettings.APIv3Key,
                       "",
                       L("DisplayName:PayCenter.Wechat.APIv3Key"),
                       L("DisplayName:PayCenter.Wechat.APIv3Key.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),

                     new SettingDefinition(
                       PayCenterSettings.Certificate,
                       "",
                       L("DisplayName:PayCenter.Wechat.Certificate"),
                       L("DisplayName:PayCenter.Wechat.Certificate.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),

                    new SettingDefinition(
                       PayCenterSettings.CertificatePassword,
                       "",
                       L("DisplayName:PayCenter.Wechat.CertificatePassword"),
                       L("DisplayName:PayCenter.Wechat.CertificatePassword.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),

                      new SettingDefinition(
                       PayCenterSettings.APIPrivateKey,
                       "",
                       L("DisplayName:PayCenter.Wechat.APIPrivateKey"),
                       L("DisplayName:PayCenter.Wechat.APIPrivateKey.DESC")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),
                       new SettingDefinition(
                       PayCenterSettings.RsaPublicKey,
                       "",
                       L("DisplayName:PayCenter.Wechat.RsaPublicKey"),
                       L("DisplayName:PayCenter.Wechat.RsaPublicKey")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Wechat")
                       .WithProperty("Type", "text"),


                     //支付宝的配置信息
                       new SettingDefinition(
                       PayCenterSettings.AlipayAppId,
                       "",
                       L("DisplayName:PayCenter.Alipay.AppId"),
                       L("DisplayName:PayCenter.Alipay.AppId.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.AlipayPublicKey,
                       "",
                       L("DisplayName:PayCenter.Alipay.AlipayPublicKey"),
                       L("DisplayName:PayCenter.Alipay.AlipayPublicKey.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.AppPrivateKey,
                       "",
                       L("DisplayName:PayCenter.Alipay.AppPrivateKey"),
                       L("DisplayName:PayCenter.Alipay.AppPrivateKey.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.ServerUrl,
                       "https://openapi.alipay.com/gateway.do",
                       L("DisplayName:PayCenter.Alipay.ServerUrl"),
                       L("DisplayName:PayCenter.Alipay.ServerUrl.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                        new SettingDefinition(
                       PayCenterSettings.Version,
                       "1.0",
                       L("DisplayName:PayCenter.Alipay.Version"),
                       L("DisplayName:PayCenter.Alipay.Version.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                      new SettingDefinition(
                       PayCenterSettings.SignType,
                       "RSA2",
                       L("DisplayName:PayCenter.Alipay.SignType"),
                       L("DisplayName:PayCenter.Alipay.SignType.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.EncryptKey,
                       "",
                       L("DisplayName:PayCenter.Alipay.EncryptKey"),
                       L("DisplayName:PayCenter.Alipay.EncryptKey.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.AppPublicCert,
                       "",
                       L("DisplayName:PayCenter.Alipay.AppPublicCert"),
                       L("DisplayName:PayCenter.Alipay.AppPublicCert.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.AlipayPublicCert,
                       "",
                       L("DisplayName:PayCenter.Alipay.AlipayPublicCert"),
                       L("DisplayName:PayCenter.Alipay.AlipayPublicCert.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text"),

                       new SettingDefinition(
                       PayCenterSettings.AlipayRootCert,
                       "",
                       L("DisplayName:PayCenter.Alipay.AlipayRootCert"),
                       L("DisplayName:PayCenter.Alipay.AlipayRootCert.Desc")
                     )
                       .WithProperty("Group1", "PayCenter")
                       .WithProperty("Group2", "Alipay")
                       .WithProperty("Type", "text")

                        );




    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PayCenterResource>(name);
    }
}
