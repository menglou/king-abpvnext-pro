using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockBizQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务编码
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
