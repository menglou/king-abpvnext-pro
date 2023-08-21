﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppCommunityOwnercardSyncModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityOwnercardSyncModel : AlipayObject
    {
        /// <summary>
        /// 支付宝uid
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 产品类型： OWNER_CARD 电子业主卡
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 卡过期时间 ,为空则默认2099-12-31 00:00:00
        /// </summary>
        [JsonPropertyName("card_expired_time")]
        public string CardExpiredTime { get; set; }

        /// <summary>
        /// 房管局卡ID
        /// </summary>
        [JsonPropertyName("card_id")]
        public string CardId { get; set; }

        /// <summary>
        /// 房管局系统中的小区id
        /// </summary>
        [JsonPropertyName("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 房屋信息是否已脱敏，1已脱敏，0未脱敏， 默认0
        /// </summary>
        [JsonPropertyName("is_room_info_desensitization")]
        public long IsRoomInfoDesensitization { get; set; }

        /// <summary>
        /// 父业主卡ID
        /// </summary>
        [JsonPropertyName("parent_card_id")]
        public string ParentCardId { get; set; }

        /// <summary>
        /// 房管局标识的唯一房屋编号
        /// </summary>
        [JsonPropertyName("room_id")]
        public string RoomId { get; set; }

        /// <summary>
        /// 房屋信息
        /// </summary>
        [JsonPropertyName("room_info")]
        public string RoomInfo { get; set; }

        /// <summary>
        /// 卡状态 ONLINE：在线 INVALID：失效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 产品子类型： HANGZHOU_OWNER_CARD 杭州房管局电子业主卡
        /// </summary>
        [JsonPropertyName("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户类型:  业主：OWNER 租客：TENANT 家属：FAMILY其他：OTHER
        /// </summary>
        [JsonPropertyName("user_type")]
        public string UserType { get; set; }
    }
}
