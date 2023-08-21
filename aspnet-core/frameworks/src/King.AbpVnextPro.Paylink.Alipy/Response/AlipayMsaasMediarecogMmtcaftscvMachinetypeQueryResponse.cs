using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinetypeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 视觉货柜机型信息列表
        /// </summary>
        [JsonPropertyName("machine_types")]
        public List<MachineType> MachineTypes { get; set; }
    }
}
