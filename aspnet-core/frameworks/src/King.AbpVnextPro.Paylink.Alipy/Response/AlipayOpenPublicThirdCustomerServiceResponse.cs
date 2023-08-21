using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicThirdCustomerServiceResponse.
    /// </summary>
    public class AlipayOpenPublicThirdCustomerServiceResponse : AlipayResponse
    {
        /// <summary>
        /// 授权给第三方渠道商的服务窗名称
        /// </summary>
        [JsonPropertyName("public_name")]
        public string PublicName { get; set; }
    }
}
