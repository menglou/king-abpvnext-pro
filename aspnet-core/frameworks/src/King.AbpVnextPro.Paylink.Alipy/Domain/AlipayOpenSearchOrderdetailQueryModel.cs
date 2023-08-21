﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenSearchOrderdetailQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenSearchOrderdetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询申请单详情的入参
        /// </summary>
        [JsonPropertyName("biz_data")]
        public SearchOrderRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 进行具体操作的类型比如：create、mod、cancel
        /// </summary>
        [JsonPropertyName("opt_type")]
        public string OptType { get; set; }
    }
}
