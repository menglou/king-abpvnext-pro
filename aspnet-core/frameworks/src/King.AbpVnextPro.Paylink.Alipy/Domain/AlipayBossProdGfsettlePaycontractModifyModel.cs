using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayBossProdGfsettlePaycontractModifyModel Data Structure.
    /// </summary>
    public class AlipayBossProdGfsettlePaycontractModifyModel : AlipayObject
    {
        /// <summary>
        /// 修改的付款条款信息
        /// </summary>
        [JsonPropertyName("paycontract")]
        public PayContractDTO Paycontract { get; set; }
    }
}
