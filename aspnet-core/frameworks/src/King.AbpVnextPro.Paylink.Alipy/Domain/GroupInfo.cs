﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// GroupInfo Data Structure.
    /// </summary>
    public class GroupInfo : AlipayObject
    {
        /// <summary>
        /// 创建者用户id
        /// </summary>
        [JsonPropertyName("creator_uid")]
        public string CreatorUid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 群ID
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 群头像url
        /// </summary>
        [JsonPropertyName("group_img")]
        public string GroupImg { get; set; }

        /// <summary>
        /// 群名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 群成员上限
        /// </summary>
        [JsonPropertyName("group_threshold")]
        public long GroupThreshold { get; set; }

        /// <summary>
        /// 群类型,0:普通群、1：经费群、5：活动群、6：娱乐群
        /// </summary>
        [JsonPropertyName("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 群主用户id
        /// </summary>
        [JsonPropertyName("master_uid")]
        public string MasterUid { get; set; }
    }
}
