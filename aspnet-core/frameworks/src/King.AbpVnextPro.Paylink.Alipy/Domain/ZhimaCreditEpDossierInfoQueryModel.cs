using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditEpDossierInfoQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpDossierInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 企业社会统一信用代码或营业执照注册号
        /// </summary>
        [JsonPropertyName("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
