﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandBenefitVerifyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandBenefitVerifyModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("biz_ext")]
        public string BizExt { get; set; }

        /// <summary>
        /// 外部业务时间
        /// </summary>
        [JsonPropertyName("out_biz_time")]
        public string OutBizTime { get; set; }

        /// <summary>
        /// 外部用户ID
        /// </summary>
        [JsonPropertyName("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 权益发放记录ID
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
