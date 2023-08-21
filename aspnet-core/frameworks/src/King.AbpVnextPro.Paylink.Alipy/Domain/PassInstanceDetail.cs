﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// PassInstanceDetail Data Structure.
    /// </summary>
    public class PassInstanceDetail : AlipayObject
    {
        /// <summary>
        /// 业务动态参数列表
        /// </summary>
        [JsonPropertyName("biz_param_list")]
        public List<BizParamKeyValue> BizParamList { get; set; }

        /// <summary>
        /// 所属商户PID/APPID（发放渠道ID）
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 卡券实例创建时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 有效期-结束时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 删除标记，是否已被用户删除
        /// </summary>
        [JsonPropertyName("is_deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// logo图片的ID或链接，模板创建时在模板JSON文本中指定
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 卡券展示标题
        /// </summary>
        [JsonPropertyName("logo_text")]
        public string LogoText { get; set; }

        /// <summary>
        /// 最后修改时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 卡券实例id，对应调卡券发放alipay.pass.instance.add接口返回的passId
        /// </summary>
        [JsonPropertyName("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 产品业务类型，模板创建时在模板JSON文本中指定
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// 卡券单据号  由商户发券时指定的卡券唯一凭证号，卡券JSON模板中fileInfo->serialNumber字段对应的值
        /// </summary>
        [JsonPropertyName("serial_number")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// 有效期-开始时间，格式"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 卡券状态：  CAN_USE：可使用；  EXPIRED：已过期；  USED：已使用（已核销）；  CLOSED：已失效；
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 图片/海报的图片ID或链接，模板创建时在模板JSON文本中指定
        /// </summary>
        [JsonPropertyName("strip")]
        public string Strip { get; set; }

        /// <summary>
        /// 模板ID（编号）
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 模板类型，模板创建时在模板JSON文本中指定
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 所属用户user_id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
