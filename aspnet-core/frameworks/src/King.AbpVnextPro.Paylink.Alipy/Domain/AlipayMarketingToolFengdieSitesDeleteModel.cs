﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesDeleteModel Data Structure.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesDeleteModel : AlipayObject
    {
        /// <summary>
        /// 待删除的站点 ID
        /// </summary>
        [JsonPropertyName("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲删除的站点所归属的空间 ID
        /// </summary>
        [JsonPropertyName("space_id")]
        public string SpaceId { get; set; }
    }
}
