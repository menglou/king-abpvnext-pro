﻿using System.Text.Json.Serialization;

namespace King.AbpVnextPro.Paylink.Alipy.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopCreateModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketShopCreateModel : AlipayObject
    {
        /// <summary>
        /// 门店详细地址，地址字符长度在4-50个字符，注：不含省市区。门店详细地址按规范格式填写地址，以免影响门店搜索及活动报名：例1：道路+门牌号，“人民东路18号”；例2：道路+门牌号+标志性建筑+楼层，“四川北路1552号欢乐广场1楼”。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店审核时需要的图片；至少包含一张门头照片，两张内景照片，必须反映真实的门店情况，审核才能够通过；多个图片之间以英文逗号分隔。
        /// </summary>
        [JsonPropertyName("audit_images")]
        public string AuditImages { get; set; }

        /// <summary>
        /// 门店授权函,营业执照与签约账号主体不一致时需要。
        /// </summary>
        [JsonPropertyName("auth_letter")]
        public string AuthLetter { get; set; }

        /// <summary>
        /// 店铺接口业务版本号，新接入的ISV，请统一传入2.0。
        /// </summary>
        [JsonPropertyName("biz_version")]
        public string BizVersion { get; set; }

        /// <summary>
        /// 门店是否有包厢，T表示有，F表示没有，不传在客户端不作展示。
        /// </summary>
        [JsonPropertyName("box")]
        public string Box { get; set; }

        /// <summary>
        /// 分店名称，比如：万塘路店，与主门店名合并在客户端显示为：肯德基(万塘路店)。
        /// </summary>
        [JsonPropertyName("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌LOGO; 图片ID，不填写则默认为门店首图main_image。
        /// </summary>
        [JsonPropertyName("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名，不填写则默认为“其它品牌”。
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 许可证，各行业所需的证照资质参见<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=205&articleId=104497&docType=1">商户入驻要求</a>；该字段只能上传一张许可证，一张以外的许可证、除营业执照和许可证之外其他证照请放在其他资质字段上传。
        /// </summary>
        [JsonPropertyName("business_certificate")]
        public string BusinessCertificate { get; set; }

        /// <summary>
        /// 许可证有效期，格式：2020-03-20或长期。严格按照格式填写。
        /// </summary>
        [JsonPropertyName("business_certificate_expires")]
        public string BusinessCertificateExpires { get; set; }

        /// <summary>
        /// 请严格按"周一-周五 09:00-20:00,周六-周日 10:00-22:00"的格式进行填写，时间段不能重复，最多支持两个时间段，24小时营业请填写"00:00-23:59"
        /// </summary>
        [JsonPropertyName("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 类目id，请参考<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=205&articleId=104497&docType=1">商户入驻要求</a>。
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 城市编码，国标码，详见国家统计局数据 <a href="https://gw.alipayobjects.com/os/basement_prod/92d874c4-39a9-4977-b710-d55dad374b7f.csv">点此下载</a>。
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店电话号码；支持座机和手机，只支持数字和+-号，在客户端对用户展现， 支持多个电话， 以英文逗号分隔。
        /// </summary>
        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// （支付宝内部参数）小二的支付宝账号。
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 区县编码，国标码，详见国家统计局数据 <a href="https://gw.alipayobjects.com/os/basement_prod/92d874c4-39a9-4977-b710-d55dad374b7f.csv">点此下载</a>。
        /// </summary>
        [JsonPropertyName("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// （支付宝内部参数）企业支付宝账号。
        /// </summary>
        [JsonPropertyName("enterprise_logon_id")]
        public string EnterpriseLogonId { get; set; }

        /// <summary>
        /// （支付宝内部参数）企业支付宝账户名称。
        /// </summary>
        [JsonPropertyName("enterprise_name")]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 机具号，多个之间以英文逗号分隔。
        /// </summary>
        [JsonPropertyName("implement_id")]
        public string ImplementId { get; set; }

        /// <summary>
        /// 是否在其他平台开店，T表示有开店，F表示未开店。
        /// </summary>
        [JsonPropertyName("is_operating_online")]
        public string IsOperatingOnline { get; set; }

        /// <summary>
        /// ISV返佣id，门店创建、或者门店交易的返佣将通过此账号反给ISV，如果有口碑签订了返佣协议，则该字段作为返佣数据提取的依据。此字段必须是个合法uid，2088开头的16位支付宝会员账号，如果传入错误将无法创建门店。
        /// </summary>
        [JsonPropertyName("isv_uid")]
        public string IsvUid { get; set; }

        /// <summary>
        /// 纬度；最长15位字符（包括小数点）， 注：高德坐标系。经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// （支付宝内部参数）leads的编号。
        /// </summary>
        [JsonPropertyName("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 门店营业执照图片，各行业所需的证照资质参见<a href="https://doc.open.alipay.com/doc2/detail.htm?treeId=205&articleId=104497&docType=1">商户入驻要求</a>。
        /// </summary>
        [JsonPropertyName("licence")]
        public string Licence { get; set; }

        /// <summary>
        /// 门店营业执照编号，只支持输入中文，英文和数字，营业执照信息与is_operating_online至少填一项。
        /// </summary>
        [JsonPropertyName("licence_code")]
        public string LicenceCode { get; set; }

        /// <summary>
        /// 营业执照过期时间。格式：2020-10-20或长期。严格按照格式填写。
        /// </summary>
        [JsonPropertyName("licence_expires")]
        public string LicenceExpires { get; set; }

        /// <summary>
        /// 门店营业执照名称。
        /// </summary>
        [JsonPropertyName("licence_name")]
        public string LicenceName { get; set; }

        /// <summary>
        /// 经度；最长15位字符（包括小数点）， 注：高德坐标系。经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数准确。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店首图，非常重要，推荐尺寸2000*1500。
        /// </summary>
        [JsonPropertyName("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 主门店名  比如：肯德基；主店名里不要包含分店名，如“万塘路店”。主店名长度不能超过20个字符。
        /// </summary>
        [JsonPropertyName("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 是否有无烟区，T表示有无烟区，F表示没有无烟区，不传在客户端不展示。
        /// </summary>
        [JsonPropertyName("no_smoking")]
        public string NoSmoking { get; set; }

        /// <summary>
        /// 门店店长电话号码；用于接收门店状态变更通知，收款成功通知等通知消息， 不在客户端展示。
        /// </summary>
        [JsonPropertyName("notify_mobile")]
        public string NotifyMobile { get; set; }

        /// <summary>
        /// 废弃字段，请使用online_url字段替代。
        /// </summary>
        [JsonPropertyName("online_image")]
        public string OnlineImage { get; set; }

        /// <summary>
        /// 其他平台开店的店铺链接url，多个url使用英文逗号隔开,isv迁移到新接口使用此字段，与is_operating_online=T配套使用。
        /// </summary>
        [JsonPropertyName("online_url")]
        public string OnlineUrl { get; set; }

        /// <summary>
        /// 表示以系统集成商的身份开店，开放平台现在统一传入ISV。
        /// </summary>
        [JsonPropertyName("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 当商户的门店审核状态发生变化时，会向该地址推送消息。
        /// </summary>
        [JsonPropertyName("operate_notify_url")]
        public string OperateNotifyUrl { get; set; }

        /// <summary>
        /// 其他资质。用于上传营业证照、许可证照外的其他资质，除已上传许可证外的其他许可证也可以在该字段上传。
        /// </summary>
        [JsonPropertyName("other_authorization")]
        public string OtherAuthorization { get; set; }

        /// <summary>
        /// 门店是否支持停车，T表示支持，F表示不支持，不传在客户端不作展示。
        /// </summary>
        [JsonPropertyName("parking")]
        public string Parking { get; set; }

        /// <summary>
        /// （支付宝内部参数）服务商要操作的商户PID。
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// （支付宝内部参数）付款方式：code_scanned_pay：付款码   online_pay：在线买单。ISV不可以指定此字段，ISV泛行业开店默认为在线买单，云纵开店可以指定支付方式。
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 省份编码，国标码，详见国家统计局数据 <a href="https://gw.alipayobjects.com/os/basement_prod/92d874c4-39a9-4977-b710-d55dad374b7f.csv">点此下载</a>。
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// （支付宝内部参数）leads开店重试支付宝流水ID。
        /// </summary>
        [JsonPropertyName("ref_apply_id")]
        public string RefApplyId { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复），在门店notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应。
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 外部门店编号；最长32位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性。
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店其他的服务，门店与用户线下兑现。
        /// </summary>
        [JsonPropertyName("value_added")]
        public string ValueAdded { get; set; }

        /// <summary>
        /// 废弃字段，使用biz_version字段替代。
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// 门店是否支持WIFI，T表示支持，F表示不支持，不传在客户端不作展示。
        /// </summary>
        [JsonPropertyName("wifi")]
        public string Wifi { get; set; }
    }
}
