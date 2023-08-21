﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseLeaseStateSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseLeaseStateSyncModel : AlipayObject
    {
        /// <summary>
        /// 租约电子合同图片，内容字节组Base64处理，支持jpg、png、jpeg、bmp格式
        /// </summary>
        [JsonPropertyName("lease_ca_file")]
        public string LeaseCaFile { get; set; }

        /// <summary>
        /// 租约编号(KA内部租约业务编号)
        /// </summary>
        [JsonPropertyName("lease_code")]
        public string LeaseCode { get; set; }

        /// <summary>
        /// 租约状态  0-未确认  1-已确认  2-已退房  3-已撤销
        /// </summary>
        [JsonPropertyName("lease_status")]
        public long LeaseStatus { get; set; }
    }
}
