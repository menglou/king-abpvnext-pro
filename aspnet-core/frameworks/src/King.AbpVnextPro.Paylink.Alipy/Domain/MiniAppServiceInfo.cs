﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// MiniAppServiceInfo Data Structure.
    /// </summary>
    public class MiniAppServiceInfo : AlipayObject
    {
        /// <summary>
        /// 插件发布状态码，暂存100，风控审核200，运营审核300，等待上架400，已预发上架500，已上架501，已下架600，已驳回700
        /// </summary>
        [JsonPropertyName("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 是否是内部标，true/false
        /// </summary>
        [JsonPropertyName("is_inner")]
        public bool IsInner { get; set; }

        /// <summary>
        /// 是否订购，true/false
        /// </summary>
        [JsonPropertyName("is_order")]
        public bool IsOrder { get; set; }

        /// <summary>
        /// 三方应用appid
        /// </summary>
        [JsonPropertyName("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 测试插件
        /// </summary>
        [JsonPropertyName("mini_app_name")]
        public string MiniAppName { get; set; }

        /// <summary>
        /// 卖家pid
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家名
        /// </summary>
        [JsonPropertyName("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 商品CODE
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务图标
        /// </summary>
        [JsonPropertyName("service_logo")]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [JsonPropertyName("service_slogan")]
        public string ServiceSlogan { get; set; }

        /// <summary>
        /// 是否在服务市场透出，SHOW展示、HIDE隐藏
        /// </summary>
        [JsonPropertyName("show_type")]
        public string ShowType { get; set; }
    }
}
