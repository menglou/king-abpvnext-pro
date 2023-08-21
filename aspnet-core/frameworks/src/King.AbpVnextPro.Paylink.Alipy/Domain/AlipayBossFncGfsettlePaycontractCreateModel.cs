using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractCreateModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractCreateModel : AlipayObject
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [JsonPropertyName("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
