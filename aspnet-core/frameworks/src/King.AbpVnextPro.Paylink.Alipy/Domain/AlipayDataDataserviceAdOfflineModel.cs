﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdOfflineModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdOfflineModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 操作的广告层级类型，如计划(plan)，单元(group)，创意 （creative），分组标识（batchTag），店铺标识（store）
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 外部平台导入广告库后，广告投放层级的对应的外部资源ID
        /// </summary>
        [JsonPropertyName("outer_id_list")]
        public List<string> OuterIdList { get; set; }
    }
}
