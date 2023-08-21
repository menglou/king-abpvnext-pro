using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayBossFncGfsettlePaycontractQueryResponse.
    /// </summary>
    public class AlipayBossFncGfsettlePaycontractQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 付款条款
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<PayContractItemApplyDTO> ResultSet { get; set; }
    }
}
