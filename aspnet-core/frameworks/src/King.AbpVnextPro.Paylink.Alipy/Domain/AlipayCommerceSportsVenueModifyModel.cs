﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayCommerceSportsVenueModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceSportsVenueModifyModel : AlipayObject
    {
        /// <summary>
        /// 变更具体位置
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 变更区域code
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 是否可预定 Y/N  （不传默认为可预定）
        /// </summary>
        [JsonPropertyName("bookable")]
        public string Bookable { get; set; }

        /// <summary>
        /// 变更城市code
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 变更场馆介绍
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 变更纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 变更经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 变更场馆名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 变更营业时间 开始时间 - 结束时间
        /// </summary>
        [JsonPropertyName("opening_hours")]
        public string OpeningHours { get; set; }

        /// <summary>
        /// 服务商场馆ID，不可变更
        /// </summary>
        [JsonPropertyName("out_venue_id")]
        public string OutVenueId { get; set; }

        /// <summary>
        /// 变更联系电话
        /// </summary>
        [JsonPropertyName("phone")]
        public List<string> Phone { get; set; }

        /// <summary>
        /// 变更场馆图片Base64编码列表 最多5张图片。要求参见场馆主图
        /// </summary>
        [JsonPropertyName("picture_list")]
        public List<string> PictureList { get; set; }

        /// <summary>
        /// poi
        /// </summary>
        [JsonPropertyName("poi")]
        public string Poi { get; set; }

        /// <summary>
        /// 变更场馆主图海报图片的Base64编码 （注：1.图片的格式必须是jpg的；2.图片大小不超过125KB；3.非Data URI格式，请直接填写原文件的base64编码）
        /// </summary>
        [JsonPropertyName("poster")]
        public string Poster { get; set; }

        /// <summary>
        /// 场馆售卖产品类型集合，逗号隔开 calendar：价格日历 ticket：票券 course: 课程
        /// </summary>
        [JsonPropertyName("product_type_list")]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// 变更省份code
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 变更状态，online/offline
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子场馆列表
        /// </summary>
        [JsonPropertyName("sub_venue_list")]
        public List<SubVenueModifyInfo> SubVenueList { get; set; }

        /// <summary>
        /// 变更标签列表
        /// </summary>
        [JsonPropertyName("tag_list")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 变更交通信息
        /// </summary>
        [JsonPropertyName("traffic")]
        public string Traffic { get; set; }

        /// <summary>
        /// 支付宝场馆ID，不可变更
        /// </summary>
        [JsonPropertyName("venue_id")]
        public string VenueId { get; set; }

        /// <summary>
        /// 场馆商户pid
        /// </summary>
        [JsonPropertyName("venue_pid")]
        public string VenuePid { get; set; }

        /// <summary>
        /// 场馆类型， 01足球；02篮球；03乒乓球；04羽毛球；05台球；06射箭；07哒哒球；08游泳；09网球；10攀岩；11空手道；12跆拳道；14瑜伽；15搏击；16舞蹈；17艺术体操；18太极；19击剑；20水上运动；21滑雪；22健身；23轮滑；24排球；25门球；00其他运动
        /// </summary>
        [JsonPropertyName("venue_type")]
        public List<string> VenueType { get; set; }
    }
}
