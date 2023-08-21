using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceEducateAuthenticateCampuscardCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateAuthenticateCampuscardCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 如果学生学籍插入成功，则返回SUCCESS ， 失败返回FAIL
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
