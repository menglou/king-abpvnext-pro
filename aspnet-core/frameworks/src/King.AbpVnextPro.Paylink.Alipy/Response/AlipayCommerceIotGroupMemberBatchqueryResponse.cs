using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayCommerceIotGroupMemberBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotGroupMemberBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 分组成员列表
        /// </summary>
        [JsonPropertyName("members")]
        public List<DeviceGroupMember> Members { get; set; }

        /// <summary>
        /// 分组中的设备总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
