﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignRetailDmCreateModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignRetailDmCreateModel : AlipayObject
    {
        /// <summary>
        /// 第三方详情页链接：该商品/活动的详细介绍，注意：该字段需要过风控校验，不得传入敏感链接
        /// </summary>
        [JsonPropertyName("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 促销结束时间，用于产品详情展示，格式为：2017-02-07 11:11:11。  注意开始时间要求早于结束时间
        /// </summary>
        [JsonPropertyName("activity_end_time")]
        public string ActivityEndTime { get; set; }

        /// <summary>
        /// 促销开始时间，在产品详情中展示，格式为：2017-02-01 11:11:11。  注意：开始时间要求早于结束时间
        /// </summary>
        [JsonPropertyName("activity_start_time")]
        public string ActivityStartTime { get; set; }

        /// <summary>
        /// 简要的促销说明，用于对促销的内容进行直接明了的说明（如会员价：10元）。注意：该字段需要过风控校验，不得传入敏感词。
        /// </summary>
        [JsonPropertyName("brief")]
        public string Brief { get; set; }

        /// <summary>
        /// 活动类型：该活动是属于单品优惠，还是全场活动，单品优惠 SINGLE,全场优惠UNIVERSAL
        /// </summary>
        [JsonPropertyName("campaign_type")]
        public string CampaignType { get; set; }

        /// <summary>
        /// 优惠类型，全场优惠传入枚举值  比如：DISCOUNT(折扣),OFF(立减),CARD(集点),VOUCHER(代金),REDEMPTION(换购),EXCHANGE(兑换),GIFT(买赠),OTHERS(其他),
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 该活动的活动文案，主要涉及（活动时间、参与方式、活动力度），最多不得超过1024个字，注意：该字段需要过风控校验，不得传入敏感词
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展备用信息，一些其他信息存入该字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 常规图片url，用于在展示图片的细节（通过alipay.offline.material.image.upload 接口上传视频/图片获取的资源id）
        /// </summary>
        [JsonPropertyName("image_id")]
        public string ImageId { get; set; }

        /// <summary>
        /// 品牌：该商品属于哪个牌子/该活动属于哪个商家（比如 海飞丝，统一，徐福记，立白......）
        /// </summary>
        [JsonPropertyName("item_brand")]
        public string ItemBrand { get; set; }

        /// <summary>
        /// 该商品/活动所属类别（吃的:食品      面膜:个人洗护    拖把:家庭清洁）
        /// </summary>
        [JsonPropertyName("item_category")]
        public string ItemCategory { get; set; }

        /// <summary>
        /// 商品编码，SKU或店内码，该编码由Isv系统传入
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名称，单品优惠时传入商品名称；全场活动时传入活动名称，注意：该字段需要过风控校验，不得传入敏感词
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 该商品/活动，是否是会员专享的，TRUE表示会员专享，FALSE表示非会员专享
        /// </summary>
        [JsonPropertyName("member_only")]
        public string MemberOnly { get; set; }

        /// <summary>
        /// 适用外部门店id，传入该优惠适用口碑门店id，可以传入多个值，列表类型
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 4:3缩略图url，用于产品在店铺页简单规范的展示。 （通过alipay.offline.material.image.upload 接口上传视频/图片获取的资源id）   注意：本图片会进行图片尺寸校验，不符合4:3尺寸则无法上传。
        /// </summary>
        [JsonPropertyName("thumbnail_image_id")]
        public string ThumbnailImageId { get; set; }
    }
}
