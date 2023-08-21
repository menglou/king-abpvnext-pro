using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenDataServiceQueryResponse.
    /// </summary>
    public class AlipayOpenDataServiceQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [JsonPropertyName("group_records")]
        public List<GroupRecord> GroupRecords { get; set; }

        /// <summary>
        /// 是否成功  true：成功  false:失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
