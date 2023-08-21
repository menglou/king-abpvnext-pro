﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenSearchAbilityBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenSearchAbilityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 搜索运营列表的查询request
        /// </summary>
        [JsonPropertyName("biz_data")]
        public SearchOperPageQueryRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：query
        /// </summary>
        [JsonPropertyName("opt_type")]
        public string OptType { get; set; }
    }
}
