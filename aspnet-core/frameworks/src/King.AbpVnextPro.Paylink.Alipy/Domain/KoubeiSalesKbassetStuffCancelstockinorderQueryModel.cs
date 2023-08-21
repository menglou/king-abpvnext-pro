﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffCancelstockinorderQueryModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffCancelstockinorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，备用
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 分页查询当前查询页码
        /// </summary>
        [JsonPropertyName("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询每页数据量
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
