﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using King.AbpVnextPro.Paylink.Alipy.Domain;

namespace King.AbpVnextPro.Paylink.Alipy.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryRequireQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryRequireQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 类目对应资质列表
        /// </summary>
        [JsonPropertyName("category_require_info_list")]
        public List<CategoryRequireInfo> CategoryRequireInfoList { get; set; }
    }
}
