﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayEbppCommunityCommunityinfoCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppCommunityCommunityinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 别名
        /// </summary>
        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 地市行政区化代码
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 社区code，例如 清波门社区 330102001051
        /// </summary>
        [JsonPropertyName("community_adcode")]
        public string CommunityAdcode { get; set; }

        /// <summary>
        /// 社区中文，如嘉绿苑社区
        /// </summary>
        [JsonPropertyName("community_adcode_name")]
        public string CommunityAdcodeName { get; set; }

        /// <summary>
        /// 小区编码，兼容迁移小区时所需；正常的非迁移的小区创建时不需要传
        /// </summary>
        [JsonPropertyName("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 区县行政区化代码
        /// </summary>
        [JsonPropertyName("county")]
        public string County { get; set; }

        /// <summary>
        /// 区县中文，如西湖区
        /// </summary>
        [JsonPropertyName("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 小区热线
        /// </summary>
        [JsonPropertyName("hot_line")]
        public string HotLine { get; set; }

        /// <summary>
        /// 服务时间结束
        /// </summary>
        [JsonPropertyName("hot_line_end")]
        public string HotLineEnd { get; set; }

        /// <summary>
        /// 服务时间开始
        /// </summary>
        [JsonPropertyName("hot_line_start")]
        public string HotLineStart { get; set; }

        /// <summary>
        /// 小区名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 外部小区号
        /// </summary>
        [JsonPropertyName("out_community_id")]
        public string OutCommunityId { get; set; }

        /// <summary>
        /// 地理信息
        /// </summary>
        [JsonPropertyName("pois")]
        public List<ExternalPoiInfo> Pois { get; set; }

        /// <summary>
        /// 省行政区化代码
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 街道code，例如 清波街道 330102001000
        /// </summary>
        [JsonPropertyName("street_adcode")]
        public string StreetAdcode { get; set; }

        /// <summary>
        /// 街道中文，如古荡街道
        /// </summary>
        [JsonPropertyName("street_adcode_name")]
        public string StreetAdcodeName { get; set; }

        /// <summary>
        /// 中心账单楼房号模式 REMOTE 中心账单户号模式 REMOTE_NO_ROOM 内部H5模式 H5 内部底座模式 SAAS 自运营账单-楼房号 EXTERNAL_BILL_ROOM 自运营账单-仅户号 EXTERNAL_BILL_BILLKEY 备注：1、中心账单楼房号模式会进行用户隐私校验     2、不确定使用哪种方式时请联系对应BD或开发
        /// </summary>
        [JsonPropertyName("support_type")]
        public string SupportType { get; set; }

        /// <summary>
        /// 业主姓名验证        NAME_VERIFY 业主手机验证        MOBILE_VERIFY 房间户号验证        ROOM_VERIFY(不传 则默认) 业主姓名+手机      NAME_MOBILE_VERIFY
        /// </summary>
        [JsonPropertyName("verify_type")]
        public string VerifyType { get; set; }
    }
}
