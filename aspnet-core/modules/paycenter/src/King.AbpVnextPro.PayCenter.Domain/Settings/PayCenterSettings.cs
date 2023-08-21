namespace King.AbpVnextPro.PayCenter.Settings;

public static class PayCenterSettings
{
    public const string GroupName = "PayCenter";

    /* Add constants for setting names. Example:
     * public const string MySettingName = GroupName + ".MySettingName";
     */

    public const string WechatGroup = GroupName+ ".Wechat";
    public const string WechatAppId= WechatGroup+ ".AppId";
    public const string WechatAppSecretId = WechatGroup + ".AppSecret";
    public const string MchId = WechatGroup + ".MchId";
    public const string SubAppId = WechatGroup + ".SubAppId";
    public const string SubMchId = WechatGroup + ".SubMchId";
    public const string APIKey =  WechatGroup + ".APIKey";
    public const string APIv3Key =  WechatGroup + ".APIv3Key";
    public const string Certificate = WechatGroup + ".Certificate";
    public const string CertificatePassword = WechatGroup + ".CertificatePassword";
    public const string APIPrivateKey = WechatGroup + ".APIPrivateKey";
    public const string RsaPublicKey =WechatGroup + ".RsaPublicKey";

    public const string AlipayGroup = GroupName + ".Alipay";
    public const string AlipayAppId = AlipayGroup + ".AppId";
    public const string AlipayPublicKey = AlipayGroup + ".AlipayPublicKey";//
    public const string AppPrivateKey = AlipayGroup + ".AppPrivateKey";//应用私钥 RSA私钥
    public const string ServerUrl = AlipayGroup + ".ServerUrl";//服务网关地址
    public const string Version = AlipayGroup + ".Version";//接口版本
    public const string SignType = AlipayGroup + ".SignType";//签名类型
    public const string EncryptKey = AlipayGroup + ".EncryptKey";//加密秘钥
    public const string AppPublicCert = AlipayGroup + ".AppPublicCert";//应用公钥
    public const string AlipayPublicCert = AlipayGroup + ".AlipayPublicCert";//支付宝公钥证书
    public const string AlipayRootCert = AlipayGroup + ".AlipayRootCert";
}
