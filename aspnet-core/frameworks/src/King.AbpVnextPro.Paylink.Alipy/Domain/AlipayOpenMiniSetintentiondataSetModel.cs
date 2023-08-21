﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenMiniSetintentiondataSetModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniSetintentiondataSetModel : AlipayObject
    {
        /// <summary>
        /// 本次更新动作类型,put:新增或覆盖,remove:删除
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 当前批次的唯一编号,对应本批次上传的多条意图数据，开发者自定义
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 用于标识数据所属的服务类目
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }

        /// <summary>
        /// 推送到服务库的数据列表,json array格式的字符串
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
    }
}
