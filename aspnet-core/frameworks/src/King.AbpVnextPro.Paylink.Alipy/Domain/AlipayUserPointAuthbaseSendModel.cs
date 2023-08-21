﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserPointAuthbaseSendModel Data Structure.
    /// </summary>
    public class AlipayUserPointAuthbaseSendModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息，用于对该笔业务调用的补充说明
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部业务流水号，长度请务必保证28位，会用于幂等性校验，所以请保证每次请求的业务流水号的唯一性
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 需要给用户发放的积分数
        /// </summary>
        [JsonPropertyName("point")]
        public string Point { get; set; }

        /// <summary>
        /// 调用方自己的业务场景类型标识，用户区分调用方和业务，请根据自己的业务来传，不传则做默认处理
        /// </summary>
        [JsonPropertyName("scene_type")]
        public string SceneType { get; set; }

        /// <summary>
        /// 用户的支付宝账户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
