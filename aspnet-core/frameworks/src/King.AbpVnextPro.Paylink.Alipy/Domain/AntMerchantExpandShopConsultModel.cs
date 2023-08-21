﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AntMerchantExpandShopConsultModel Data Structure.
    /// </summary>
    public class AntMerchantExpandShopConsultModel : AlipayObject
    {
        /// <summary>
        /// 门店结算卡信息。本业务当前只允许传入一张结算卡。 说明：本参数仅直付通业务使用，其余业务无需关注。
        /// </summary>
        [JsonPropertyName("biz_cards")]
        public List<SettleCardInfo> BizCards { get; set; }

        /// <summary>
        /// 品牌id，非加油站等特殊门店无需关注。
        /// </summary>
        [JsonPropertyName("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 经营地址。地址对象中省、市、区、地址必填，其余选填
        /// </summary>
        [JsonPropertyName("business_address")]
        public AddressInfo BusinessAddress { get; set; }

        /// <summary>
        /// 店铺经营时间。
        /// </summary>
        [JsonPropertyName("business_time")]
        public List<ShopBusinessTime> BusinessTime { get; set; }

        /// <summary>
        /// 营业执照图片，需传入<a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a> 接口上传图片后得到的 image_id。 注意： * 蚂蚁门店管理场景可选。 * 间连 M1、M2商家创建门店，必须传入营业执照图片。
        /// </summary>
        [JsonPropertyName("cert_image")]
        public string CertImage { get; set; }

        /// <summary>
        /// 营业执照名称，填写值为营业执照或统一社会信用代码证上的名称。 注意：若传入 cert_no，则本参数必填。
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号码，请填写店铺营业执照号。 注意： * 蚂蚁门店管理场景可选。 * 间连 M1、M2商家创建门店，必须传入营业执照号。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，取值范围：201：营业执照；2011:多证合一(统一社会信用代码)。 注意：若传入 cert_no，则本参数必填。
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 联系人信息。如果填写，其中名称必填，手机、固话、email 三选一必填。
        /// </summary>
        [JsonPropertyName("contact_infos")]
        public List<ContactInfo> ContactInfos { get; set; }

        /// <summary>
        /// 店铺联系手机，与店铺联系固话二选一必填
        /// </summary>
        [JsonPropertyName("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 店铺的联系固话，和店铺联系手机二选一必填
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展信息列表。key值需要向对应行业的bd进行申请。
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public List<ShopExtInfo> ExtInfos { get; set; }

        /// <summary>
        /// 商户角色id，表示将要开的店属于哪个商户角色。对于直连开店场景，填写商户pid；对于间连开店场景（线上、线下、直付通），填写商户smid。特别说明：IoT设备三绑定场景统一填写商户pid
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 法人身份证号。蚂蚁门店管理场景可选。
        /// </summary>
        [JsonPropertyName("legal_cert_no")]
        public string LegalCertNo { get; set; }

        /// <summary>
        /// 法人名称。蚂蚁门店管理场景可选。
        /// </summary>
        [JsonPropertyName("legal_name")]
        public string LegalName { get; set; }

        /// <summary>
        /// 营业执照授权函。需传入<a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a>  接口上传图片后得到的 image_id。 蚂蚁门店管理场景可选。
        /// </summary>
        [JsonPropertyName("license_auth_letter_image")]
        public string LicenseAuthLetterImage { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 门头照 id，需传入 <a href="https://opendocs.alipay.com/apis/api_1/ant.merchant.expand.indirect.image.upload">ant.merchant.expand.indirect.image.upload</a> 接口上传图片后得到的 image_id。 蚂蚁门店管理场景可选。
        /// </summary>
        [JsonPropertyName("out_door_images")]
        public string OutDoorImages { get; set; }

        /// <summary>
        /// 行业特殊资质。
        /// </summary>
        [JsonPropertyName("qualifications")]
        public List<IndustryQualificationInfo> Qualifications { get; set; }

        /// <summary>
        /// 场景，非加油站等特殊门店无需关注。
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 结算支付宝账号的登录号，需传入小程序归属账号。若需增加收款账号，可在创建门店后登录<a href="https://b.alipay.com/index2.htm">商家中心</a> ，在 账户中心 > 经营信息 > 门店管理 中选择对应门店选择 更多 > 编辑 > 新增收款账号。
        /// </summary>
        [JsonPropertyName("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 新版门店类目标准二级类目code。类目标准及与原类目映射关系参见 <a href="https://ur.alipay.com/4cmn0n">支付宝门店类目-最新</a> 表格。
        /// </summary>
        [JsonPropertyName("shop_category")]
        public string ShopCategory { get; set; }

        /// <summary>
        /// 店铺名称。直连开店要保证全局店铺名称+地址唯一，间连开店要保证服务商pid下店铺名称+地址唯一
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺经营类型，01表示直营，02表示加盟
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 门店编号，表示该门店在该商户角色id(直连pid，间连smid)下，由商户自己定义的外部门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
