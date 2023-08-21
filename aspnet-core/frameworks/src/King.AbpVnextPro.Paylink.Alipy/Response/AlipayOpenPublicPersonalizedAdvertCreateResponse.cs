using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedAdvertCreateResponse.
    /// </summary>
    public class AlipayOpenPublicPersonalizedAdvertCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 轮播广告分组id
        /// </summary>
        [JsonPropertyName("advert_group")]
        public string AdvertGroup { get; set; }
    }
}
