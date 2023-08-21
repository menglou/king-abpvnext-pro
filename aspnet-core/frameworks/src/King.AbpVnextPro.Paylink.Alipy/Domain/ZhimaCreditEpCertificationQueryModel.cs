using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// ZhimaCreditEpCertificationQueryModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpCertificationQueryModel : AlipayObject
    {
        /// <summary>
        /// 一次认证的唯一标识,在商户调用认证初始化接口的时候获取
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }
    }
}
