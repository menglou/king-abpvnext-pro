using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddResponse.
    /// </summary>
    public class AlipayMsaasMediarecogMmtcaftscvMachinegoodsAddResponse : AlipayResponse
    {
        /// <summary>
        /// 柜内区域状态
        /// </summary>
        [JsonPropertyName("regions")]
        public List<RegionState> Regions { get; set; }
    }
}
