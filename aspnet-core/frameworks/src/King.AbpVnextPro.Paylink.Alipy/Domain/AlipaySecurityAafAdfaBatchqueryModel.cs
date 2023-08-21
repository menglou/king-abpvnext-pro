using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipaySecurityAafAdfaBatchqueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityAafAdfaBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}
