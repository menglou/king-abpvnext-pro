using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayDataDataserviceUserlevelZrankGetResponse.
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 活跃高价值用户返回
        /// </summary>
        [JsonPropertyName("result")]
        public AlipayHighValueCustomerResult Result { get; set; }
    }
}
