using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 1111112141414
        /// </summary>
        [JsonPropertyName("s")]
        public string S { get; set; }
    }
}
