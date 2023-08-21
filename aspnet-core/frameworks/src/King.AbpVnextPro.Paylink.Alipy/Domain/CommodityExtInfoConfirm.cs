﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// CommodityExtInfoConfirm Data Structure.
    /// </summary>
    public class CommodityExtInfoConfirm : AlipayObject
    {
        /// <summary>
        /// 城市上架结果 【 0：表示失败，  1：表示成功】
        /// </summary>
        [JsonPropertyName("city_status")]
        public string CityStatus { get; set; }

        /// <summary>
        /// 挂载ID，用于确认唯一记录的主键对象
        /// </summary>
        [JsonPropertyName("displayapp_id")]
        public string DisplayappId { get; set; }

        /// <summary>
        /// 修改城市记录映射对应的原有的挂载id,如果原有服务没有上架城市，该参数为空
        /// </summary>
        [JsonPropertyName("mapping_displayapp_id")]
        public string MappingDisplayappId { get; set; }

        /// <summary>
        /// 城市上架失败原因
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }
    }
}
