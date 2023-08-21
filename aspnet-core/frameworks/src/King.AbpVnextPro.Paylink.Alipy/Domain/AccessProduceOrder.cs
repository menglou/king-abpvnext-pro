﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AccessProduceOrder Data Structure.
    /// </summary>
    public class AccessProduceOrder : AlipayObject
    {
        /// <summary>
        /// 口碑码批次号
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 生产单标识
        /// </summary>
        [JsonPropertyName("produce_order_id")]
        public string ProduceOrderId { get; set; }

        /// <summary>
        /// 生产数量
        /// </summary>
        [JsonPropertyName("produce_quantity")]
        public long ProduceQuantity { get; set; }

        /// <summary>
        /// 物料属性名称
        /// </summary>
        [JsonPropertyName("stuff_attr_name")]
        public string StuffAttrName { get; set; }

        /// <summary>
        /// 物料材质
        /// </summary>
        [JsonPropertyName("stuff_material")]
        public string StuffMaterial { get; set; }

        /// <summary>
        /// 物料尺寸
        /// </summary>
        [JsonPropertyName("stuff_size")]
        public string StuffSize { get; set; }

        /// <summary>
        /// 物料类型
        /// </summary>
        [JsonPropertyName("stuff_type")]
        public string StuffType { get; set; }

        /// <summary>
        /// 模板唯一标识
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
