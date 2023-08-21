﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeaccountCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicLifeaccountCreateModel : AlipayObject
    {
        /// <summary>
        /// 勾选同意生活号协议（true：同意，false：不同意）
        /// </summary>
        [JsonPropertyName("agreement")]
        public string Agreement { get; set; }

        /// <summary>
        /// 号主页背景图
        /// </summary>
        [JsonPropertyName("background")]
        public string Background { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        [JsonPropertyName("biz_license_no")]
        public string BizLicenseNo { get; set; }

        /// <summary>
        /// 商标授权
        /// </summary>
        [JsonPropertyName("brand_authorization")]
        public List<string> BrandAuthorization { get; set; }

        /// <summary>
        /// 生活号的简介信息
        /// </summary>
        [JsonPropertyName("brief_introduction")]
        public string BriefIntroduction { get; set; }

        /// <summary>
        /// 营业执照图片地址
        /// </summary>
        [JsonPropertyName("business_license")]
        public string BusinessLicense { get; set; }

        /// <summary>
        /// 行业类目mcc类目code
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 联系人电子邮件
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 作为生活号管理者的联系人
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [JsonPropertyName("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("customer_tel")]
        public string CustomerTel { get; set; }

        /// <summary>
        /// 生活号头像地址
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 菜单信息（非必填）（一级菜单最多4个，具体的菜单格式，见文档
        /// </summary>
        [JsonPropertyName("menu_info")]
        public string MenuInfo { get; set; }

        /// <summary>
        /// 生活号名称（店铺名等）
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 平台帐号id（比如1688帐号id）
        /// </summary>
        [JsonPropertyName("platform_account_id")]
        public string PlatformAccountId { get; set; }

        /// <summary>
        /// 平台码（标识1688、饿了么等）
        /// </summary>
        [JsonPropertyName("platform_unique_id")]
        public string PlatformUniqueId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
