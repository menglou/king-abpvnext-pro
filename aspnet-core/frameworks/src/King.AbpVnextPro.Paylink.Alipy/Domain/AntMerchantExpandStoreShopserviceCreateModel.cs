﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandStoreShopserviceCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandStoreShopserviceCreateModel : AlipayObject
    {
        /// <summary>
        /// 素材上传的安全云oss的accessKey
        /// </summary>
        [JsonPropertyName("access_key_id")]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// true/false, 是否有效；默认为true
        /// </summary>
        [JsonPropertyName("is_valid")]
        public bool IsValid { get; set; }

        /// <summary>
        /// 场景服务名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商家接收通知的手机号
        /// </summary>
        [JsonPropertyName("notify_phone")]
        public string NotifyPhone { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 具体描述预约的业务场景
        /// </summary>
        [JsonPropertyName("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// 线下门店的服务项目列表
        /// </summary>
        [JsonPropertyName("service_items")]
        public List<ShopServiceItem> ServiceItems { get; set; }

        /// <summary>
        /// 服务时间信息
        /// </summary>
        [JsonPropertyName("service_time")]
        public ServiceTimeInfo ServiceTime { get; set; }

        /// <summary>
        /// 线下门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 服务人员
        /// </summary>
        [JsonPropertyName("shop_staffs")]
        public List<ShopStaffInfo> ShopStaffs { get; set; }

        /// <summary>
        /// 线上店的ID
        /// </summary>
        [JsonPropertyName("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
