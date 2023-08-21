using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务id
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
