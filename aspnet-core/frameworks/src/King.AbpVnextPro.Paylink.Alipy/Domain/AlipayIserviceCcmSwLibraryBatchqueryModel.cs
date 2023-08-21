using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }
    }
}
