using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenAppOpenbizmockOpenidnonstandQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppOpenbizmockOpenidnonstandQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求
        /// </summary>
        [JsonPropertyName("request")]
        public string Request { get; set; }
    }
}
