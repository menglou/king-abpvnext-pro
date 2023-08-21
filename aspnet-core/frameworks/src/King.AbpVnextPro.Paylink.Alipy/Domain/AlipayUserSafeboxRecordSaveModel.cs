﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserSafeboxRecordSaveModel Data Structure.
    /// </summary>
    public class AlipayUserSafeboxRecordSaveModel : AlipayObject
    {
        /// <summary>
        /// 用钢铁匣公钥加密后的内容
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 用于加密传输标题和内容的钢铁匣密钥版本。默认值1
        /// </summary>
        [JsonPropertyName("key_version")]
        public string KeyVersion { get; set; }

        /// <summary>
        /// 钢铁匣为接入方提供的应用场景码。一个APPID可以对应多个场景码
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用钢铁匣公钥加密后的标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 唯一id，用作幂等。每一个唯一id只能对应一条记录。同一个场景码下，对应多个唯一id
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
