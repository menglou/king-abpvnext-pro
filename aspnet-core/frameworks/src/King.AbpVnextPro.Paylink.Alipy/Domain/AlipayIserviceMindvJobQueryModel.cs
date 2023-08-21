﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceMindvJobQueryModel : AlipayObject
    {
        /// <summary>
        /// 问卷id_系统内唯一_根据问卷id查询问卷相关信息
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
