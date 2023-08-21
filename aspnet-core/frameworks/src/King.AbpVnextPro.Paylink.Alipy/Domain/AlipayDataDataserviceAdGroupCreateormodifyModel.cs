﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdGroupCreateormodifyModel Data Structure.
    /// </summary>
    public class AlipayDataDataserviceAdGroupCreateormodifyModel : AlipayObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [JsonPropertyName("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 数据集id列表
        /// </summary>
        [JsonPropertyName("conversion_data_id_list")]
        public List<string> ConversionDataIdList { get; set; }

        /// <summary>
        /// 转化事件编号（废弃）。若此字段不为空，则要求conversion_type也不为空，且此转化事件与转化事件类型conversion_type匹配
        /// </summary>
        [JsonPropertyName("conversion_id")]
        public string ConversionId { get; set; }

        /// <summary>
        /// 转化目标之转化事件id列表
        /// </summary>
        [JsonPropertyName("conversion_id_list")]
        public List<string> ConversionIdList { get; set; }

        /// <summary>
        /// 转化事件类型： CPA_TAO_XI：淘系店铺关注 CPA_TMALL_MEMBER_JOIN：淘系店铺入会
        /// </summary>
        [JsonPropertyName("conversion_type")]
        public string ConversionType { get; set; }

        /// <summary>
        /// 业务扩展参数字段，根据第三方需要使用，投放端只做存储并向检索端透传
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 单元出价，单位：分
        /// </summary>
        [JsonPropertyName("group_charge")]
        public long GroupCharge { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 外部唯一单元编号
        /// </summary>
        [JsonPropertyName("group_outer_id")]
        public string GroupOuterId { get; set; }

        /// <summary>
        /// 单元状态：ENABLE-生效；DISABLE-暂停。 若此入参字段为空：新建单元时此字段默认有效；修改单元此字段默认为单元当前状态。
        /// </summary>
        [JsonPropertyName("group_status")]
        public string GroupStatus { get; set; }

        /// <summary>
        /// 商品id列表
        /// </summary>
        [JsonPropertyName("item_id_list")]
        public List<string> ItemIdList { get; set; }

        /// <summary>
        /// 是否使用OCPX智能出价，只再CPC场景下，支持开启OCPX： OPEN: 打开；CLOSE: 关闭
        /// </summary>
        [JsonPropertyName("ocpx_switch")]
        public string OcpxSwitch { get; set; }

        /// <summary>
        /// 外部唯一计划编号
        /// </summary>
        [JsonPropertyName("plan_outer_id")]
        public string PlanOuterId { get; set; }

        /// <summary>
        /// 转化目标成本，只有开启OCPX后才需要配置，单位为分
        /// </summary>
        [JsonPropertyName("target_cpa")]
        public long TargetCpa { get; set; }

        /// <summary>
        /// 定向扩展信息
        /// </summary>
        [JsonPropertyName("targeting_extend_info")]
        public string TargetingExtendInfo { get; set; }

        /// <summary>
        /// 单元定向列表。目前支持的定向类型有：  REGION_LIST: 实时地址  AD_POS_LIST: 广告位定向  OUTER_KOUBEI_INTEREST_TAG_LIST: 口碑偏好  OUTER_KOUBEI_CROWD_TAG_LIST：口碑人群
        /// </summary>
        [JsonPropertyName("targeting_list")]
        public List<OuterTargetingItem> TargetingList { get; set; }

        /// <summary>
        /// 投放区间内的投放时段
        /// </summary>
        [JsonPropertyName("time_option")]
        public string TimeOption { get; set; }

        /// <summary>
        /// 投放时段配置，bitmap。规则：7个int用「,」分隔组成的字符串；每个int中第0位表示0点，第1位表示1点。如此类推; 7个int的排序是星期日、星期一、星期二、星期三、星期四、星期五、星期六
        /// </summary>
        [JsonPropertyName("time_schema")]
        public string TimeSchema { get; set; }
    }
}
