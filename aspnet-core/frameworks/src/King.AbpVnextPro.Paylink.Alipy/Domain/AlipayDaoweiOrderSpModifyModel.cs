﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDaoweiOrderSpModifyModel Data Structure.
    /// </summary>
    public class AlipayDaoweiOrderSpModifyModel : AlipayObject
    {
        /// <summary>
        /// 到位业务订单号，全局唯一，由32位数字组成，用户在到位下单时系统生成并消息同步给商家，商户只能查自己同步到的订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部服务者id，由商户自己生成，保证同一商户id唯一，同步服务者信息或者修改订单服务者信息时设置，长度不超过64个字符
        /// </summary>
        [JsonPropertyName("out_sp_id")]
        public string OutSpId { get; set; }
    }
}
