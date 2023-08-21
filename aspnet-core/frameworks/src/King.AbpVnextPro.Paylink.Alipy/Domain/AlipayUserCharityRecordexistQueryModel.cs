﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayUserCharityRecordexistQueryModel Data Structure.
    /// </summary>
    public class AlipayUserCharityRecordexistQueryModel : AlipayObject
    {
        /// <summary>
        /// 公益的业务类型(缺省是所有类型)
        /// </summary>
        [JsonPropertyName("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 捐赠记录的结束时间（默认是查询当前自然年一年的记录）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户和支付宝交互时，用于代表支付宝分配给商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 捐赠记录的开始时间（默认是查询当前自然年一年的记录）
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
