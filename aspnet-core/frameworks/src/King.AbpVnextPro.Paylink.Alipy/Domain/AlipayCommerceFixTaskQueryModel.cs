﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceFixTaskQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceFixTaskQueryModel : AlipayObject
    {
        /// <summary>
        /// 工单唯一id。 获取途径：创建工单的返回结果id，或者通知消息中的工单id进行查询。
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
